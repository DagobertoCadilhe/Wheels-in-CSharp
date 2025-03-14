namespace Wheels
{
    internal class Customer
    {
        private static int _nextId = 1;
        private int _id;
        private string _personalId;
        private string _name;
        private string _email;
        private int _phone;
        private List<Bike> _rentedBikes = new List<Bike>
        {
        };

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Use a valid name");
                }
                _name = value;
            }
        }


        public Customer(string PersonalId, string Name, string Email, int Phone)
        {
            _id = _nextId++;
            _personalId = PersonalId;
            _name = Name;
            _email = Email;
            _phone = Phone;
        }

        public void ReturnInformation()
        {
            Console.WriteLine($"Sys ID : {_id} | Personal ID : {_personalId} | Name : {_name} | Email : {_email} " +
                $"| Phone : {_phone}");
        }

        public void RentBike(Bike bike)
        {
            _rentedBikes.Add(bike);
        }

        public void ReturnBike(Bike bike)
        {
            _rentedBikes.Remove(bike);
        }
    }
}
