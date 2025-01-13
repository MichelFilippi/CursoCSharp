using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassMethod {
    internal class DefaultValue {

        public static int Soma(int a = 1, int b = 2) {
            return a+ b;
        }
        public static void Execute() {
            Console.WriteLine(Soma(10,10));
            Console.WriteLine(Soma(10));
            Console.WriteLine(Soma());
            Console.WriteLine(Soma(b:7));

        }
    }
}
