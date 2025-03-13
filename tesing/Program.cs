namespace Wheels
{
    public class Program 
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Yo");

            RentalManager manager = new RentalManager();

            manager.ReturnAvalibleBikes();
        }
    }
}