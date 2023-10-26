
namespace CarManufacturer
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            double result = FuelQuantity - (distance * FuelConsumption);
            if (result >= 0) FuelQuantity -= result;
            else Console.WriteLine("Not enough fuel to perform this trip!");
        }

        public string WhoAmI()
        {
            return
               $"Make: {Make}\n" +
               $"Model: {Model}\n" +
               $"Year: {Year}\n" +
               $"Fuel: {FuelQuantity:F2}";
        }
    }

}
