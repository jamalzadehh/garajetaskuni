using System;
using System.Text.RegularExpressions;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {



        }



    }
    public abstract class Vehicle
    {
        public string _company { get; set; }
        public string _model { get; set; }
        public int _year { get; set; }

        public Vehicle(string company, string model, int year)
        {
            _company = company;
            _model = model;
            _year = year;
        }

        public abstract void Start();
    }

    public class Car : Vehicle
    {
        public Car(string company, string model, int year) : base(company, model, year)
        {

        }

        public override void Start()
        {
            Console.WriteLine("Mashin started");
        }

    }
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string company, string model, int year) : base(company, model, year)
        {

        }
       
        public override void Start()
        {
            Console.WriteLine("Motorsikl started");
        }
    }
    public class Truck : Vehicle
    {
        public Truck(string company, string model, int year) : base(company, model, year)
        {

        }                
        public override void Start()
        {
            Console.WriteLine("Kamaz ishe dusdu");
        }
    }
    public class Garage
    {
        private Vehicle[] vehicles = new Vehicle[0];
        private int vehiclesCount;

        public void ShowVehicles()
        {
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle._company} {vehicle._model} {vehicle._year}");
            }
        }
        public void AddNew(Vehicle vehicle)
        {
            

        }

    


}
