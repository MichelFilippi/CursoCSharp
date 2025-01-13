using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassMethod {
    internal class Members {
        public static void Execute() {
            People p1 = new People();
            p1.name = "João";
            p1.age = 10;

            Console.WriteLine($"Meu nome é {p1.name} tenho {p1.age}");

            p1.ShowAll();
        }
    }
}
