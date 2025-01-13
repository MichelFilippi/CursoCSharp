using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassMethod {
    public class  Dependent {
        public string Name;
        public int Age;
        
        
    }
    internal class ValueRef {
        public static void Execute() {
            int num = 4;
            int numCopy = num;
            Console.WriteLine($"{num} {numCopy}");

            num++;
            Console.WriteLine($"{num} {numCopy}");

            Dependent dep = new Dependent {
                Name = "Carlos",
                Age = 10
            };

            Dependent depCopy = dep;
            Console.WriteLine($"{dep.Name} {depCopy.Name}");
            Console.WriteLine($"{dep.Age} {depCopy.Age}");
            dep.Name = "Marcos";
            dep.Age = 15;
            Console.WriteLine($"{dep.Name} {depCopy.Name}");
            Console.WriteLine($"{dep.Age} {depCopy.Age}");


        }
    }
}
