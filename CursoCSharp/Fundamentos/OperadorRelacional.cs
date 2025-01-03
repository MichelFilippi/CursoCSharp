using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadorRelacional {
        public static void Execute() {
            Console.Write("Digite sua nota: ");
            double.TryParse(Console.ReadLine(),out double nota);
            double notaCorte = 7.0;

            Console.WriteLine("Nota Invalida? {0}", nota > 10.0);
            Console.WriteLine("Nota Invalida? {0}", nota < 10.0);
            Console.WriteLine("Parabens!! {0}", nota == 10.0);
            Console.WriteLine("Melhore {0}", nota != 10.0);
            Console.WriteLine("Passou por média {0}", nota >= notaCorte);
            Console.WriteLine("Está de recuperação {0}", nota < notaCorte);
            Console.WriteLine("Reprovado {0}", nota <= 3.0);







        }
    }
}
