namespace Wheels
{
    internal class RentalManager
    {
        private Customer Customer;
        private readonly List<Bike> _avalibleBikes = new List<Bike>()
        {
            new Bike(100, 15),
            new Bike(200, 20),
            new Bike(150, 18)
        };
        private readonly List<Bike> _borrowedBikes = new List<Bike>
        {
        };
        private readonly List<Customer> _customers = new List<Customer>
        {
            new Customer("123456789", "Alice Johnson", "alice@example.com", 1234567890),
            new Customer("987654321", "Bob Smith", "bob@example.com", 1234567890),
            new Customer("456789123", "Charlie Brown", "charlie@example.com", 1234567890)
        };

        public void ReturnAvalibleBikes()
        {
            if (_avalibleBikes != null)
            {
                _avalibleBikes.ForEach(b => b.ReturnInformation());
            }
            else
            {
                Console.WriteLine("There are no bikes avalible for rental!");
            }
            
        }
        public void ReturnRentedBikes()
        {
            if (_borrowedBikes != null) 
            {
                _borrowedBikes.ForEach(b => b.ReturnInformation());
            }
            else
            {
                Console.WriteLine("There are no rented bikes, rent one now!");
            }
            
        }
        public void ReturnRegistredCustomers()
        {
            if (_customers != null)
            {
                _customers.ForEach(c => c.ReturnInformation());
            }
            else
            {
                Console.WriteLine("There are no registred customers yet");
            }
            
        }

        public void RegisterCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public void RentABike(Customer customer, Bike bike)
        {
            _avalibleBikes.RemoveAt(_avalibleBikes.IndexOf(bike));
            _borrowedBikes.Add(bike);
            customer.RentBike(bike);
        }

        public void ReturnABike(Customer customer, Bike bike)
        {
            _borrowedBikes.RemoveAt(_borrowedBikes.IndexOf(bike));
            _avalibleBikes.Add(bike);
            customer.ReturnBike(bike);
        }
    }
}
