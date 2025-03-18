namespace Wheels;

internal class RentalManager
{
    private readonly List<Hire> _activeHires = new List<Hire>();
    BikeManager bikeManager = new BikeManager();
    CustomerManager customerManager = new CustomerManager();

    public void RentBike()
    {
        bool loop = true;
        int choice = -1;

        while(loop)
        {
            Console.Clear();
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
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                try
                {
                    int customerChoice = -1;

                    while (customerChoice == -1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("===========================================");
                        Console.WriteLine("     Customer Choice - Choose an Action    ");
                        Console.WriteLine("===========================================");
                        Console.ResetColor();

                        Console.WriteLine("\nChoose 1 of the following options:");
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        customerManager.ReturnRegistredCustomers();

                        Console.ResetColor();

                        Console.Write("\nEnter your choice: ");
                        if (int.TryParse(Console.ReadLine(), out customerChoice))
                        {
                            Customer customer = customerManager.ReturnCustomerById(customerChoice);
                            Bike bike = bikeManager.ReturnBikeById(customerChoice);
                            DateTime dateTime = DateTime.Now;

                            Console.WriteLine("\nHow many days? :");
                            int.TryParse(Console.ReadLine(), out int numberOfDays);

                            Hire hire = new Hire(dateTime, numberOfDays, bike, customer);

                            _activeHires.Add(hire);
                            hire.DisplayHireInformation();

                            loop = false;
                            
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nInvalid input. Please enter a valid customer ID.");
                            Console.ResetColor();
                            customerChoice = -1;
                        }
                    }

                    Bike selectedBike = bikeManager.ReturnBikeById(choice);
                    bikeManager.RentABike(selectedBike);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nBike rental processed successfully!");
                    Console.ResetColor();
                }
                catch(Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nError: {ex.Message}");
                    Console.ResetColor();
                    choice = -1;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid input. Please enter a valid bike ID.");
                Console.ResetColor();
                choice = -1;
            }
        }
    }
}
