using Task_10._2___03._06._2024.Entities;
using Task_10._2___03._06._2024.Enums;

namespace Task_10._2___03._06._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many Car do you want to enter: ");
            int? stop = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < stop; i++)
            {
                Car car = new Car();
                Console.Write("Enter car brand: ");
                string brand = Console.ReadLine();
                car.Brand = brand;


                Console.Write("Enter car model: ");
                string model = Console.ReadLine();
                car.Model = model;

                Console.WriteLine("Enter car type (Sport, SUV, Sedan): ");
                while (true)
                {
                    string typeInput = Console.ReadLine();
                    if (typeInput.Trim().ToLower() == "sport" || typeInput.Trim().ToLower() == "sedan" || typeInput.Trim().ToLower() == "suv")
                        break;
                    else
                        Console.WriteLine("Invalid car type. Please enter either Sport, SUV, or Sedan: ");
                }
                
                
                Console.WriteLine(car.ToS)
            }

            
        }
    }
}