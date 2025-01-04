using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ControlStatement {
    internal class StructureDoWhile {
        public static void Execute() {
            string input;

            do {
                Console.WriteLine("Qual o seu nome?");
                input = Console.ReadLine();

                Console.WriteLine("Bem vindo {0}", input);
                Console.WriteLine("Deseja Continuar (S/N)");
                input = Console.ReadLine();
            } while (input.ToUpper() == "S");
        }
    }
}
