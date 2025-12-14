using Google.Cloud.Firestore;
using QuizShared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerForm.Services
{
    public class QuizManager
    {
        private readonly FirestoreDb _db;

        public QuizManager()
        {
            _db = FirestoreService.Db;
        }

        private CollectionReference Rooms => _db.Collection("rooms");
        private CollectionReference Quizzes => _db.Collection("quizzes");

        public async Task StartQuizAsync(string roomId)
        {
            var roomRef = Rooms.Document(roomId);
            var roomSnap = await roomRef.GetSnapshotAsync();
            if (!roomSnap.Exists)
                return;

            Room room = roomSnap.ConvertTo<Room>();

            var quizSnap = await Quizzes.Document(room.QuizId).GetSnapshotAsync();
            if (!quizSnap.Exists)
                return;

            Quiz quiz = quizSnap.ConvertTo<Quiz>();

            await roomRef.UpdateAsync(new Dictionary<string, object>
            {
                { "Questions", quiz.Questions },
                { "State", QuizState.InQuestion },
                { "CurrentQuestionIndex", 0 }
            });
        }

        public async Task NextQuestionAsync(string roomId, int nextIndex)
        {
            var roomRef = Rooms.Document(roomId);

            await _db.RunTransactionAsync(async tx =>
            {
                var snap = await tx.GetSnapshotAsync(roomRef);
                if (!snap.Exists)
                    return;

                var room = snap.ConvertTo<Room>();

                foreach (var p in room.Players.Values)
                {
                    p.SelectedAnswer = null;
                }

                tx.Update(roomRef, new Dictionary<string, object>
        {
            { "Players", room.Players },
            { "State", QuizState.InQuestion },
            { "CurrentQuestionIndex", nextIndex }
        });
            });
        }

        public async Task ShowResultAsync(string roomId)
        {
            var roomRef = Rooms.Document(roomId);
            var snap = await roomRef.GetSnapshotAsync();
            if (!snap.Exists)
                return;

            Room room = snap.ConvertTo<Room>();
            int qIndex = room.CurrentQuestionIndex;

            var keys = new List<string>(room.Players.Keys);

            foreach (var key in keys)
            {
                Player p = room.Players[key];

                if (p.LastScoredQuestionIndex == qIndex)
                    continue;

                if (p.SelectedAnswer == room.Questions[qIndex].CorrectAnswer)
                {
                    p.Score += 1;
                }

                p.LastScoredQuestionIndex = qIndex;
                room.Players[key] = p;
            }

            await roomRef.UpdateAsync(new Dictionary<string, object>
            {
                { "Players", room.Players },
                { "State", QuizState.ShowingResult }
            });
        }

        public async Task FinishQuizAsync(string roomId)
        {
            var roomRef = Rooms.Document(roomId);
            await roomRef.UpdateAsync("State", QuizState.Finished);
        }
    }
}
