using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermCarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;




            {

                Console.WriteLine("Welcome to the Grand Circus Motors");
                Console.WriteLine();

            }
            List<Car> CarList = new List<Car>();

            CarList.Add(new Car("Nikolai", "Model S", 2017, 54999.90));
            CarList.Add(new Car("Fourd", "Escapade", 2017, 31999.00));
            CarList.Add(new Car("Chewie", "Vette", 2017, 44989.95));
            CarList.Add(new UsedCar("Hyonda", "Prior", 2015, 14795.50, 35987.6));
            CarList.Add(new UsedCar("GC", "Chirpus", 2013, 8500.00, 12345.0));
            CarList.Add(new UsedCar("GC", "Witherell", 2016, 14450.00, 3500.3));






            while (true)
            {

                //display list of options
                ShowMenu();
                string input = Console.ReadLine();
                int number = 0;
                //!TrtParse returns bool, if false;
                while(!int.TryParse(input, out number)||number < 1 || number > 6)
                {
                    Console.WriteLine("This is not valid input. Please enter 1-6.");
                    input = Console.ReadLine();
                }

                if (number == 1)
                {
                    //display list of cars
                    CarLot.DisplayList(CarList);


                }
                //what conditions need to be met
                else if (number == 2)
                {
                    //create a new car and add it to the list
                    CarList.Add(CarLot.CreateCar(CarList));

                }
                else if (number == 3)
                {
                    CarLot.DisplayList(CarList);
                    Console.WriteLine("Which car would you like to remove?");
                    //delete a car based on user input
                    index = Convert.ToInt32(Console.ReadLine());
                    CarLot.Remove(CarList, index - 1);
                }
                else if (number == 4)
                {
                    CarLot.DisplayList(CarList);
                    Console.WriteLine("Which car would you like to know more information about?");
                    //output car information based on user input.
                    index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(CarList[index - 1].ToString());

                }
                else if (number == 5)
                {

                    CarLot.DisplayList(CarList);
                    Console.WriteLine("Which car would you like to replace?");
                    //replace a car based on user input.
                    index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(CarList[index - 1].ToString());
                    CarList.RemoveAt(index - 1);
                    CarList.Insert(index - 1, CarLot.CreateCar(CarList));
                    
                }
                else if (number == 6)
                {
                    Console.WriteLine("GoodBye!");
                    return;
                }
            

            }

        }

        static void ShowMenu()
        {
            Console.WriteLine("1. List all cars.\n2. Add a car.\n3. Remove a car.\n4. Look up a car in a given position\n5. Replace a car in a given position\n6. Quit\n");

            Console.WriteLine("What do you want to do?");
        }
    }
}
