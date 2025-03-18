namespace Wheels.UI;

internal class RentalUI
{
    private readonly RentalManager _rentalManager;
    private readonly BikeManager _bikeManager;
    private readonly CustomerManager _customerManager;

    public RentalUI(RentalManager rentalManager, BikeManager bikeManager, CustomerManager customerManager)
    {
        _rentalManager = rentalManager;
        _bikeManager = bikeManager;
        _customerManager = customerManager;
    }


    // Void RUN
    //
    // Rental menu  Rent a bike, Return A bike, View active rentals
    // With all necessary handles
    // Old code at : https://dontpad.com/relux
}
