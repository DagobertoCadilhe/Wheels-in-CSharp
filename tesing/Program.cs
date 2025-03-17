namespace Wheels
{
    public class Program 
    { 
        static void Main(string[] args)
        {
            int option = -1;
            
            RentalManager rentalManager = new RentalManager();
            CustomerManager customerManager = new CustomerManager();
            BikeManager bikeManager = new BikeManager();

            while (option == -1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("===========================================");
                Console.WriteLine("         Welcome to Bike Rental System    ");
                Console.WriteLine("===========================================");
                Console.ResetColor();

                Console.WriteLine("\nChoose an option:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1. Register Customer");
                Console.WriteLine("2. Rent a Bike");
                Console.WriteLine("3. Return a Bike");
                Console.WriteLine("4. List Available Bikes");
                Console.WriteLine("5. List Registered Customers");
                Console.WriteLine("0. Exit");
                Console.ResetColor();

                Console.Write("\nChoose: ");

                int.TryParse(Console.ReadLine(), out option);
                switch (option)
                {
                    case 1:
                        int id = -1;
                        string name = "";
                        string email = "";
                        int phone = -1;

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("=====================================");
                        Console.WriteLine("          Register New Customer      ");
                        Console.WriteLine("=====================================");
                        Console.ResetColor();

                        Customer registerCustomer = new Customer(id, name, email, phone);

                        Console.WriteLine("\nEnter personal id: ");
                        int.TryParse(Console.ReadLine(), out id);
                        registerCustomer.PersonalId = id;

                        Console.WriteLine("\nEnter Full Name: ");
                        name = Console.ReadLine();
                        registerCustomer.Name = name;

                        Console.WriteLine("\nEnter Email Address: ");
                        email = Console.ReadLine();
                        registerCustomer.Email = email;

                        Console.WriteLine("\nEnter Phone Number: ");
                        int.TryParse(Console.ReadLine(), out phone);
                        registerCustomer.Phone = phone;
                        

                        customerManager.RegisterCustomer(registerCustomer);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nCustomer Registered Successfully!");
                        Console.ResetColor();

                        break;

                    case 2:
                        rentalManager.RentBike();
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("=====================================");
                        Console.WriteLine("              Return Bike            ");
                        Console.WriteLine("=====================================");
                        Console.ResetColor();

                        Console.WriteLine("\nEnter personal bike id: ");
                        int.TryParse(Console.ReadLine(), out id);

                        bikeManager.WhereIsBike(id);
                        break;
                }
            }
        }
    }
}