﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadorTernario {
        public static void Execute() {
            double nota = 10.0;
            bool BomComportamento = false;
            string resultado = nota >= 7.0 && BomComportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);

        }
    }
}
