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


        public void ReturnAvalibleBikes()
        {
            _avalibleBikes.ForEach(b => b.ReturnInformation());
        }
    }
}
