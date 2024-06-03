using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_10___03._06._2024.Helpers;

namespace Task_10___03._06._2024
{
    public class Hotel
    {
        public string Name { get; set; }
        private Room[] rooms = new Room[0];

        public Hotel(string name)
        {
            Name = name;
        }

        public void AddRoom(Room room)
        {
            Array.Resize(ref rooms, rooms.Length + 1);
            rooms[rooms.Length - 1] = room;
        }

        public void MakeReservation(int? roomId)
        {

            if (roomId == null)
                throw new NullReferenceException("Room ID cannot be null.");

            Room room = Array.Find(rooms, r => r.Id == roomId.Value);

            if (room == null)
                throw new ArgumentException($"Room with ID {roomId.Value} not found.");

            if (!room.IsAvailable)
                throw new NotAvailableException($"Room with ID {roomId.Value} is not available.");

            room.IsAvailable = false;
            Console.WriteLine($"Room with ID {roomId.Value} has been successfully reserved.");

        }
    }
}
