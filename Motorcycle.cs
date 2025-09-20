using System;

namespace VehicleDemo
{
    public class Motorcycle : Vehicle
    {
        public string Name { get; set; }

        public Motorcycle(string name) => Name = name;

        public void Start() => Console.WriteLine($"{Name} is Starting");
        public void Drive() => Console.WriteLine($"{Name} is Driving");
        public void Stop()  => Console.WriteLine($"{Name} is Stopping");
    }
}
