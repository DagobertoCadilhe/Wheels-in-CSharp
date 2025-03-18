namespace Wheels;

internal class BikeManager
{
    private readonly List<Bike> _avalibleBikes = new List<Bike>()
    {
        new Bike(100, 15),
        new Bike(200, 20),
        new Bike(150, 18)
    };
    private readonly List<Bike> _borrowedBikes = new List<Bike>
    {
        new Bike(500, 29)
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

    public Bike ReturnBikeById(int id)
    {
        var bikeToReturn = _avalibleBikes.FirstOrDefault(b => b.Id == id);

        if (bikeToReturn != null)
        {
            return bikeToReturn;
        }
        else
        {
            throw new ArgumentException("No bikes where found to be returned");
        }
    }

    public void WhereIsBike(int id)
    {
        var bikeToReturnAvalible = _avalibleBikes.FirstOrDefault(b => b.Id == id);

        if (bikeToReturnAvalible != null)
        {
            Console.WriteLine($"The bike with ID {id} is available now.");
            bikeToReturnAvalible.ReturnInformation();
            return;
        }
        var bikeToReturnBorrowed = _borrowedBikes.FirstOrDefault(b => b.Id == id);

        if (bikeToReturnBorrowed != null)
        {
            Console.WriteLine($"The bike with ID {id} is currently rented.");
            bikeToReturnBorrowed.ReturnInformation();
            return;
        }

        Console.WriteLine($"No bike found with ID {id}.");
    }

    public void RentABike(Bike bike)
    {
        _avalibleBikes.RemoveAt(_avalibleBikes.IndexOf(bike));
        _borrowedBikes.Add(bike);
    }
    
    public void ReturnABike(Bike bike)
    {
        _borrowedBikes.RemoveAt(_borrowedBikes.IndexOf(bike));
        _avalibleBikes.Add(bike);
    }
}
