using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Task_10._2___03._06._2024.Enums;

namespace Task_10._2___03._06._2024.Entities
{
    public class Car
    {
        private static int _counter;

        static Car()
        {
            _counter = 0;
        }
        public Car()
        {
            _counter++;
            Id = _counter;
        }

        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public CarTypes Type { get; set; }

        public Car( string brand, string model, CarTypes type)
        {
            Id = ++_counter;
            Brand = brand;
            Model = model;
            Type = type;
        }

        public string ShowInfo()
        {
            return ($"Id: {Id}  " +
                $"Brand: {Brand}  " +
                $"Model: {Model}  " +
                $"Type: {Type}");
        }

        public override string ToString()
        {
            return ShowInfo().ToString();
        }
    }
}
