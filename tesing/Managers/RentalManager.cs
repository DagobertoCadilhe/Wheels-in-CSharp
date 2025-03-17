namespace Wheels
{
    internal class RentalManager
    {
        BikeManager bikeManager = new BikeManager();
        CustomerManager customerManager = new CustomerManager();

        public void RentBike()
        {
            int choice = -1;

            while(choice == -1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("===========================================");
                Console.WriteLine("        Bike Rental - Choose an Action    ");
                Console.WriteLine("===========================================");
                Console.ResetColor();

                Console.WriteLine("\nChoose 1 of the following options:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                bikeManager.ReturnAvalibleBikes();
                Console.ResetColor();

                Console.Write("\nEnter your choice: ");
                int.TryParse(Console.ReadLine(), out choice);

                bikeManager.RentABike(bikeManager.ReturnBikeById(choice));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nBike rental processed successfully!");
                Console.ResetColor();

            }

        }
    }
}
