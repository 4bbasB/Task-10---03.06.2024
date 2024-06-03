using Task_10._2___03._06._2024.Entities;
using Task_10._2___03._06._2024.Enums;

namespace Task_10._2___03._06._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("How many Car do you want to enter: ");
                int? stop = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < stop; i++)
                {
                    Console.Write("Enter car brand: ");
                    string brand = Console.ReadLine();


                    Console.Write("Enter car model: ");
                    string model = Console.ReadLine();

                    Console.WriteLine("Enter car type (Sport, SUV, Sedan): ");
                    string type = Console.ReadLine();
                    while (true)
                    {
                        if (type.Trim().ToLower() == "sport")
                        {
                            Car car = new Car(brand, model, CarTypes.Sport);
                            Console.WriteLine(car.ToString());
                            break;
                        }
                        else if (type.Trim().ToLower() == "sedan")
                        {
                            Car car = new Car(brand, model, CarTypes.Sedan);
                            Console.WriteLine(car.ToString());
                            break;
                        }
                        else if (type.Trim().ToLower() == "suv")
                        {
                            Car car = new Car(brand, model, CarTypes.SUV);
                            Console.WriteLine(car.ToString());
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid car type. Please enter either Sport, SUV, or Sedan: ");
                            type = Console.ReadLine();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            


        }
    }
}