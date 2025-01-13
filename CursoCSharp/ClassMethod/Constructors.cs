using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassMethod {

    internal class Constructors {

        public static void Execute() {
            Car c1 = new Car("325i", "BMW", 2023);
            Car c2 = new Car();

            c2.Brand = "BMW";
            c2.Year = 2023;
            c2.Model = "325i";
            Console.WriteLine($"{c1.Model} {c1.Year} {c1.Brand}");
            Console.WriteLine($"{c2.Model} {c2.Year} {c2.Brand}");
        }
    }
    class Car {
        public string Model;
        public string Brand;
        public int Year;

        public Car(string model, string brand, int year) {
            this.Model = model;
            this.Brand = brand;
            this.Year = year;

        }
        public Car() {

        }
    }
}
