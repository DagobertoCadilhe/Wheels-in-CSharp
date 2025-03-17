using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Xml;

namespace Wheels
{
    internal class Bike
    {
        private static int _nextId = 1;
        private static List<Bike> _allBikes = new List<Bike>();
        private int _id { get; set; }
        private double _depositAmount { get; set; }
        private double _dailyRate { get; set; }

        public int Id 
        { 
            get { return _id; }
        }

        public double DepositAmount
        {
            get { return _depositAmount; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Deposit amount cant be negative!");
                }
                _depositAmount = value;
            }
        }

        public double DailyRate
        {
            get { return _dailyRate; }
            set
            {
                if(value > 0)
                {
                    throw new ArgumentException("Daily rate cant be negative!");
                }
            }
        }

        public Bike(double DepositAmount, double DailyRate)
        {
            _id = _nextId++;
            _depositAmount = DepositAmount;
            _dailyRate = DailyRate;

            _allBikes.Add(this);
        }

        public void ReturnInformation()
        {
            Console.WriteLine($"Bike info: ID : {_id} | DepositAmount : {_depositAmount} | DailyRate : {_dailyRate}");
        }
    }
}