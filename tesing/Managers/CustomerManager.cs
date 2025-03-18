namespace Wheels;

internal class CustomerManager
{
    private readonly List<Customer> _customers = new List<Customer>
    {
        new Customer(123456789, "Alice Johnson", "alice@example.com", 1234567890),
        new Customer(987654321, "Bob Smith", "bob@example.com", 1234567890),
        new Customer(456789123, "Charlie Brown", "charlie@example.com", 1234567890)
    };


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

    public Customer ReturnCustomerById(int id)
    {
        var bikeToReturn = _customers.FirstOrDefault(b => b.Id == id);

        if (bikeToReturn != null)
        {
            return bikeToReturn;
        }
        else
        {
            throw new ArgumentException("No bikes where found to be returned");
        }
    }

    public void RegisterCustomer(Customer customer)
    {
        _customers.Add(customer);
    }
    public void RemoveCustomer(Customer customer)
    {
        _customers.Remove(customer);
    }
}
