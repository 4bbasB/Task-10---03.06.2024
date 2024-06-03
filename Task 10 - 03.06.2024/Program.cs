using Task_10___03._06._2024.Helpers;

namespace Task_10___03._06._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hotel name: ");
            string hotelName = Console.ReadLine();
            Hotel hotel = new Hotel(hotelName);

            for (int i = 1; i <= 2; i++)
            {
                try
                {
                    Console.Write($"Enter room {i} name: ");
                    string roomName = Console.ReadLine();
                    Console.Write($"Enter room {i} price: ");
                    double roomPrice = double.Parse(Console.ReadLine());
                    Console.Write($"Enter room {i} capacity: ");
                    int roomCapacity = int.Parse(Console.ReadLine());

                    Room room = new Room(roomName, roomPrice, roomCapacity);
                    hotel.AddRoom(room);
                }
                catch(NullReferenceException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

            }
            for (int i = 1; i <= 2; i++)
            {
                try
                {
                    Console.Write("Enter room ID to reserve: ");
                    string roomIdInput = Console.ReadLine();
                    int? roomId = string.IsNullOrEmpty(roomIdInput) ? (int?)null : int.Parse(roomIdInput);

                    hotel.MakeReservation(roomId);
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (NotAvailableException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

        }
    }
}