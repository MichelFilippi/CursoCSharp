using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Interpolacao {
        public static void Execute() {
            string nome = "Notebook";
            string marca = "Dell";
            double preco = 3000.90;

            Console.WriteLine(nome + " da marca " + marca + " é o valor de " + preco);
            Console.WriteLine("O {0} da marca {1} custa {2}", nome,marca,preco);
            Console.WriteLine($"A marca {marca} eu compro! ");
        }
    }
}
