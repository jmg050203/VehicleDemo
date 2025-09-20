using System;

namespace VehicleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[3]
            {
                new Car("Toyota Car"),
                new Truck("Volvo Truck"),
                new Motorcycle("Yamaha Motorcycle")
            };

            foreach (var v in vehicles)
            {
                v.Start();
                v.Drive();
                v.Stop();
                Console.WriteLine();
            }
        }
    }
}
