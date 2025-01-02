using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class LendoDados {
        public static void Execute() {
            Console.Write("Qual o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual o seu salário? ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"{nome} {idade} {salario} ");
        }
    }
}
