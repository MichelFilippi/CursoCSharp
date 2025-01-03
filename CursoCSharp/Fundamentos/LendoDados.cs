using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class LendoDados {
        public static void Execute() {
            Console.Write("Qual o seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine(nome);

            Console.Write("Qual sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} R${salario} ");
        }
    }
}
