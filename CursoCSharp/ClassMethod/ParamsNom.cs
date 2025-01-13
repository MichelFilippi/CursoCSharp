using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassMethod {
    internal class ParamsNom {

        public static void Formatar(int mes, int dia, int ano) {
            Console.WriteLine("{0:D2}/{1:D2}/{2}",mes, dia, ano);

        }


        public static void Execute() {
            Formatar(dia:1,mes: 6,ano: 1999);

        }
    }
}
