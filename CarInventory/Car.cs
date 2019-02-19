using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarInventory
{
    public class Car
    {
        public string make, colour;
        public int year, mileage;

        public Car(string _make, string _colour, int _year, int _mileage)
        {
            make = _make;
            colour = _colour;
            year = _year;
            mileage = _mileage;
        }
    }
}
