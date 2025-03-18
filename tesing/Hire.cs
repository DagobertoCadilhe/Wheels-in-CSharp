using System;

namespace Wheels;

internal class Hire
{
    private static int _nextId = 1;
    private int _id;
    private DateTime _startDate;
    private int _numberOfDays;

    private Customer _customer;
    private Bike _bike;

    public int Id
    {
        get { return _id; }
    }

    public DateTime StartDate
    {
        get { return _startDate; }
        set { _startDate = value; }
    }

    public int NumberOfDays
    {
        get { return _numberOfDays; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Number of days must be positive!");
            }
            _numberOfDays = value;
        }
    }

    public Customer Customer
    {
        get { return _customer; }
    }

    public Bike Bike
    {
        get { return _bike; }
    }


    public Hire(DateTime startDate, int numberOfDays, Bike bike, Customer customer)
    {
        _id = _nextId++;
        _startDate = startDate;

        if (numberOfDays <= 0)
        {
            throw new ArgumentException("Number of days must be positive!");
        }
        _numberOfDays = numberOfDays;

        _bike = bike ?? throw new ArgumentNullException(nameof(bike), "Bike cannot be null");
        _customer = customer ?? throw new ArgumentNullException(nameof(customer), "Customer cannot be null");
    }

    public double CalculateTotalCost()
    {
        return (_numberOfDays * Bike.DailyRate) + Bike.DepositAmount;
    }

    public DateTime EndDate()
    {
        TimeSpan duration = TimeSpan.FromDays(_numberOfDays);
        return _startDate + duration;
    }

    public void DisplayHireInformation()
    {
        DateTime endDate = EndDate(); 

        Console.WriteLine($"Hire ID: {_id}");
        Console.WriteLine($"Customer: {_customer.Name}");
        Console.WriteLine($"Bike ID: {_bike.Id}");
        Console.WriteLine($"Start Date: {_startDate.ToShortDateString()}");
        Console.WriteLine($"End Date: Days : {endDate.ToShortDateString()}");
        Console.WriteLine($"Number of Days: {_numberOfDays}");
        Console.WriteLine($"Total Cost: {CalculateTotalCost()}");
    }
}
