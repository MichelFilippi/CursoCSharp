﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colections {
    internal class Igualdade {
        public static void Execute() {
            var p1 = new Produto("Caneta",1.99);
            var p2 = new Produto("Caneta",1.99);
            var p3 = p2;

            Console.WriteLine(p1 == p2);
            Console.WriteLine(p3 == p2);


            Console.WriteLine(p1.Equals(p2));



        }
    }
}
