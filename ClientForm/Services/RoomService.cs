using Google.Cloud.Firestore;
using QuizShared.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ClientForm.Services
{
    public class RoomService
    {
        private readonly FirestoreDb _db = FirebaseService.Db;

        private FirestoreChangeListener _roomListener;

        private FirestoreChangeListener _roomsListener;

        public async Task<List<Room>> GetRoomsAsync()
        {
            List<Room> result = new List<Room>();

            QuerySnapshot snap = await _db.Collection("rooms").GetSnapshotAsync();
            foreach (var doc in snap.Documents)
            {
                result.Add(doc.ConvertTo<Room>());
            }

            return result;
        }

        public void ListenRooms(Action<List<Room>> onUpdate)
        {
            _roomsListener = _db.Collection("rooms").Listen(snapshot =>
            {
                var rooms = new List<Room>();

                foreach (var doc in snapshot.Documents)
                {
                    if (doc.Exists)
                    {
                        rooms.Add(doc.ConvertTo<Room>());
                    }
                }

                onUpdate?.Invoke(rooms);
            });
        }

        public Task JoinRoomAsync(string roomId, Player player)
        {
            return _db.Collection("rooms")
                .Document(roomId)
                .UpdateAsync($"Players.{player.Uid}", player);
        }

        public void ListenRoom(string roomId, Action<Room> onUpdate)
        {
            DocumentReference docRef = _db.Collection("rooms").Document(roomId);

            _roomListener = docRef.Listen(snapshot =>
            {
                if (snapshot == null || !snapshot.Exists)
                    return;

                Room r = snapshot.ConvertTo<Room>();
                onUpdate?.Invoke(r);
            });
        }

        public void Stop()
        {
            if (_roomListener != null)
            {
                _roomListener.StopAsync(CancellationToken.None)
                             .GetAwaiter()
                             .GetResult();
                _roomListener = null;
            }

            if (_roomsListener != null)
            {
                _roomsListener.StopAsync(CancellationToken.None)
                              .GetAwaiter()
                              .GetResult();
                _roomsListener = null;
            }
        }
    }
}
