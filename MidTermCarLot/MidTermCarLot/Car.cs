using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermCarLot
{
    class Car
    {
        private string make;

        public string Make { get => make; set => make = value; }
      
        private string model;
        public string Model { get => model; set => model = value; }

        private int year;
        public int Year { get => year; set => year = value; }

        private double price;
        public double Price { get => price; set => price = value; }

        public Car()
        {
            
        }

        public Car(string Make, string Model, int Year, double Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
        }

        public override string ToString()
        {
            return String.Format("{0,10} {1,15} {2,20} {3,25}", make, model, year, price);
        }

    }
}
