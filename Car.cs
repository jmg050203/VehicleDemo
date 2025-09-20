using System;

namespace VehicleDemo
{
    public class Car : Vehicle
    {
        public string Name { get; set; }

        public Car(string name) => Name = name;

        public void Start() => Console.WriteLine($"{Name} is Starting");
        public void Drive() => Console.WriteLine($"{Name} is Driving");
        public void Stop()  => Console.WriteLine($"{Name} is Stopping");
    }
}
