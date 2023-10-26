﻿
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }
        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            Engine = engine;
            Tires = tires;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        public void Drive(double distance)
        {
            if ((FuelQuantity - (distance * FuelConsumption)) >= 0)
            {
                FuelQuantity -= FuelQuantity - (distance * FuelConsumption);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Year: {Year}");
            sb.AppendLine($"HorsePowers: {Engine.HorsePower}");
            sb.AppendLine($"FuelQuantity: {FuelQuantity}");

            return sb.ToString();
        }

        public static Func<Car, bool> GetSpecialCar()
        {
            return car =>
            car.Year >= 2017
            && car.Engine.HorsePower > 330
            && car.Tires.Sum(tire => tire.Pressure) >= 9
            && car.Tires.Sum(tire => tire.Pressure) <= 10;
        }
    }

    public class Engine
    {
        public Engine(int horsePower, double cubicCapacity)
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }

        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }
    }

    public class Tire
    {
        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }

        public int Year { get; set; }
        public double Pressure { get; set; }
    }

}