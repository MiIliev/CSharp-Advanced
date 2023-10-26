using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Tire[]> tires = CollectTires();
            List<Engine> engines = CollectEngines();
            List<Car> cars = CollectCars(engines, tires);
            List<Car> specialCars = cars.Where(Car.GetSpecialCar()).ToList();
            specialCars.ForEach(car => car.Drive(20));
            specialCars.ForEach(car => Console.WriteLine(car.ToString()));
            
        }



        static List<Tire[]> CollectTires()
        {
            List<Tire[]> tires = new List<Tire[]>();
            string input = null;
            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Tire[] tireArr = new Tire[4]
                {
                    new Tire (int.Parse(command[0]), double.Parse(command[1])),
                    new Tire(int.Parse(command[2]), double.Parse(command[3])),
                    new Tire(int.Parse(command[4]), double.Parse(command[4])),
                    new Tire(int.Parse(command[6]), double.Parse(command[5]))
                };
                tires.Add(tireArr);
            }

            return tires;
        }

        private static List<Engine> CollectEngines()
        {
            List<Engine> engines = new List<Engine>();
            string input = null;
            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                engines.Add(new Engine
                    (int.Parse(command[0]),
                    double.Parse(command[1])));
            }
            return engines;
        }

        private static List<Car> CollectCars(List<Engine> engines, List<Tire[]> tires)
        {
            List<Car> cars = new List<Car>();
            string input = null;
            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string make = command[0];
                string model = command[1];
                int year = int.Parse(command[2]);
                double fuelQuantity = double.Parse(command[3]);
                double fuelConsumption = double.Parse(command[4]);
                Engine engine = engines[int.Parse(command[5])];
                int tiresIndex = int.Parse(command[6]);

                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires[tiresIndex]));
            }
            return cars;
        }
    }
}
