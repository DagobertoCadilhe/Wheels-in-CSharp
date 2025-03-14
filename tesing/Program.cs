namespace Wheels
{
    public class Program 
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Yo");
            int option = -1;
            RentalManager manager = new RentalManager();

            // manager.ReturnAvalibleBikes();
            // manager.ReturnRegistredCustomers();

            Console.WriteLine("Fake");
            Console.WriteLine("Choose : ");
            option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                    string id = "";
                    string name = "";
                    string email = "";
                    int phone = -1;

                    Console.WriteLine("Register Customer");

                    Console.WriteLine("Enter ID: ");
                    id = Console.ReadLine();

                    Console.WriteLine("Enter Name: ");
                    name = Console.ReadLine();

                    Console.WriteLine("Enter Email: ");
                    email = Console.ReadLine();

                    Console.WriteLine("Enter Phone: ");
                    int.TryParse(Console.ReadLine(), out phone);

                    Customer registerCustomer = new Customer(id, name, email, phone);
                    manager.RegisterCustomer(registerCustomer);

                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
            manager.ReturnRegistredCustomers();
        }
    }
}