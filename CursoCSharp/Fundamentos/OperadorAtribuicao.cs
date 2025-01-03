using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadorAtribuicao {
        public static void Execute() {
            int num = 3;
            num += 10;
            num -= 10;
            num *= 10;
            num /= 10;
            Console.WriteLine(num);

            int a = 1;
            int b = a;

            a++;
            b--;

            Console.WriteLine($"{a} {b}");

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
        }
    }
}
