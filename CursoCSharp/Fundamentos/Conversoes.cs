using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Conversoes {
        public static void Execute() {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            Console.Write("Digite sua idade: ");
            String palavra = Console.ReadLine();
            int idade = int.Parse(palavra);
            Console.WriteLine("Idade é de: {0}", idade);

            Console.Write("Digite um número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado é: {0}", numero2);

        }
    }

}
