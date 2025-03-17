using System.ComponentModel.DataAnnotations;

namespace Wheels
{
    internal class Customer
    {
        private static int _nextId = 1;
        private int _id;
        private int _personalId;
        private string _name;
        private string _email;
        private int _phone;

        private List<Bike> _rentedBikes = new List<Bike>
        {
        };

        public int PersonalId
        {
            get { return _personalId; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Phone number must be postive!");
                }
                _personalId = value;
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Use a valid name!");
                }
                _name = value;
            }
        }
        public string Email 
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrEmpty(value) || !value.Contains("@"))
                {
                    throw new ArgumentNullException("Enter with a valid email!");
                }
                _email = value;
            }
        }
        public int Phone
        {
            get { return _phone; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Phone number must be postive!");
                }
                _phone = value;
            }
        }


        public Customer(int PersonalId, string Name, string Email, int Phone)
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
