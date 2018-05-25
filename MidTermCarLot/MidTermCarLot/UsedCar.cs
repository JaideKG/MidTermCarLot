using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermCarLot
{
    class UsedCar: Car
    {
        private double mileage;

        public double Mileage { get => mileage; set => mileage = value; }

        //Constructor
        public UsedCar(string Make, string Model, int Year, double Price, double Mileage): base(Make, Model, Year, Price)
        {
            this.Mileage = Mileage;
        }

        
        public override string ToString()
        {
            return base.ToString() + $"{Mileage, 10}";
        }



        
    }
}
