using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermCarLot
{
    class CarLot

    {
        public static void DisplayList(List<Car> CarList)
        {
            int counter = 0;
            Console.WriteLine("       Make            Model                   Year                   Price     Miles");
            Console.WriteLine("=======================================================================================");
            foreach (Car item in CarList)
            {
                counter++;
                Console.WriteLine(counter + " . " + item.ToString());
            }
            Console.WriteLine();


        }

        //Allowing the user to create a car
        public static Car CreateCar(List<Car> CarList)
        {
            Console.WriteLine("Is this a New or Used Car?");
            string input = Console.ReadLine();

            Console.WriteLine("What is the make of the car?");
            string make = Console.ReadLine();

            Console.WriteLine("What is the model of the car?");
            string model = Console.ReadLine();

            Console.WriteLine("What is the year?");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the price?");
            double price = Convert.ToDouble(Console.ReadLine());
            
            if(input == "used") 
            {
                Console.WriteLine("What is the mileage?");

                double mileage = Convert.ToDouble(Console.ReadLine());


                Car usedCar = (new UsedCar(make, model, year, price, mileage));

                return usedCar;
            }
            else
            {
                Car usedCar = (new Car(make, model, year, price));
                return usedCar;
            }





        }

        public static void Remove(List<Car>CarList, int index)
        {

            CarList.RemoveAt(index);
        }
        
    }
}
