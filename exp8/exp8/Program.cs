using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace exp8
{
    public class car
    {
        private static string manufature;
        private static string modal;
        private int year;
        static car()
        {
            manufature = "Tayota";
            Console.WriteLine("Static constructor called"+manufature);
        }

        private car(string model)
        {
            modal = "corolla";
            year = 2020;
            modal = model;
            Console.WriteLine("private Constructor called "+modal+"year: "+year);
        }
        public car(string model,int year)
        {
            this.year = year;
            modal = model;
            Console.WriteLine("Instance constuction called");
        }
        public static car createDefaultCar()
        {
            return new car("corolla");
        }

        public void display_details()
        {
            Console.WriteLine("car Details"+manufature+modal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            new car("mycar", 2002);
            car defaultcar = car.createDefaultCar();
            defaultcar.display_details();
            Console.ReadLine();

        }
    }
}
