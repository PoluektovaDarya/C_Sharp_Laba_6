using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("400 км", "400", "220");
            Console.WriteLine(car.GetInfo(car));

            Ship ship = new Ship("чуть более пяти лет без дозаправки", "10000", "30");
            Console.WriteLine(ship.GetInfo(ship));

            Airplane airplane = new Airplane("16000 км", "23000", "850");
            Console.WriteLine(airplane.GetInfo(airplane));
        }
    }
    public abstract class Transport
    {
        public string Speed { get; set; }
        public string Carrying { get; set; }
        public string Path { get; set; }
        public string GetInfo(Transport transport)
        {
            string transportType = transport.GetType().Name;
            if (transportType == "Car") transportType = "Машина";
            if (transportType == "Ship") transportType = "Корабль";
            if (transportType == "Airplane") transportType = "Самолет";
            return $"{transportType} грузоподъемностью в {Carrying} кг может преодолеть {Path} со скоростью {Speed}";
        }
        public Transport(string path, string carrying, string speed)
        {
            Speed = speed;
            Carrying = carrying;
            Path = path;
        }
        public abstract string ForOverride { get; protected set; }
    }
    public class Car : Transport
    {
        public Car(string speed, string carrying, string path) : base(speed, carrying, path) { }
        public override string ForOverride { get; protected set; }
    }
    public class Ship : Transport
    {
        public Ship(string speed, string carrying, string path) : base(speed, carrying, path) { }
        public override string ForOverride { get; protected set; }
    }
    public class Airplane : Transport
    {
        public Airplane(string speed, string carrying, string path) : base(speed, carrying, path) { }
        public override string ForOverride { get; protected set; }
    }

}