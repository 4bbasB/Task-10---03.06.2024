using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10___03._06._2024
{
    public class Room
    {
        private static int _counter;

        static Room()
        {
            _counter = 0;
        }
        public Room()
        {
            _counter++;
            Id = _counter;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; } = true;


        public Room(string name, double price, int personCapacity)
        {
            Id = ++_counter;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }

        public string ShowInfo()
        {
            return ($"Id: {Id}" +
                $"Name: {Name}" +
                $"Price: {Price}" +
                $"Person Capacity: {PersonCapacity} +" +
                $"Is Available: {IsAvailable}");
        }

        public override string ToString()
        {
            return ShowInfo().ToString();
        }

    }
}
