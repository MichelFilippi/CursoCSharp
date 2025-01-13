using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassMethod {

    public class CalcStati {
        public static int add(int a, int b) {
            return a + b;
        }
        public static int mult(int a, int b) {
            return a * b;
        }
    }



    internal class Static {
        public static void Execute() {
            var result = CalcStati.mult(2, 2);
            Console.WriteLine($"O resultado é {result}");
        }
    }
}

