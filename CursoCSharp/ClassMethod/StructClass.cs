using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassMethod {

    public struct SDot {
        public int  X;
        public int  Y;
    }
    public class CDot {
        public int X;
        public int Y;
    }



    internal class StructClass {
        public static void Execute() {

            SDot p1 = new SDot {X = 1, Y = 3 };
            SDot p1Copy = p1;
            p1.X = 3;

            Console.WriteLine("Ponto 1 é X:{0}", p1.X);
            Console.WriteLine("Copia do Ponto 1 é X:{0}", p1Copy.X);

            CDot p2 = new CDot {X = 4, Y = 5 };
            CDot p2Copy = p2;
            p2.X = 8;

            Console.WriteLine("Ponto 2 é X:{0}", p2.X);
            Console.WriteLine("Copia do ponto 2 é X:{0}",p2Copy.X);

        }
    }
}
