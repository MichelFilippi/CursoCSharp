using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAritimeticos {
        public  static void Execute() {
            Console.WriteLine();
            int preco = 1000;
            int imposto = 355;
            double desconto = 0.1;

            double total = (preco + imposto);
            double comDesconto = total - (total * desconto);
            Console.WriteLine("O preço é de: {0}", comDesconto);

            double peso = 60;
            double altura = 1.70;

            double IMC = peso / Math.Pow(altura,2);

            Console.WriteLine($"O IMC é de: {IMC}");

            int par = 24;
            int impar = 25;

            Console.WriteLine("{0}/2 tem o valor restante de {1}.", par, par % 2);
            Console.WriteLine("{0}/2 tem resto de {1}",impar, impar % 2);



                
        }
    }
}
