namespace Wheels;

internal class RentalManager
{
    private readonly List<Hire> _activeHires = new List<Hire>();
    private readonly BikeManager _bikeManager;
    private readonly CustomerManager _customerManager;

    public RentalManager(BikeManager bikeManager, CustomerManager customerManager)
    {
        _bikeManager = bikeManager;
        _customerManager = customerManager;
    }

    public void RentBike(int bikeId, int customerId, int numberOfDays)
    {
        {
            Bike bike = _bikeManager.ReturnBikeById(bikeId);
            Customer customer = _customerManager.ReturnCustomerById(customerId);

            DateTime rentalDate = DateTime.Now;
            Hire hire = new Hire(rentalDate, numberOfDays, bike, customer);

            _activeHires.Add(hire);

            _bikeManager.RentABike(bike);
        }
    }
}
