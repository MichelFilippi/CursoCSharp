using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ControlStatement {
    internal class StructureSwitch {
        public static void Execute() {
            Console.Write("Digite a nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int value);

            switch (value) {
                case 0:
                    Console.WriteLine("Horrivel");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Boa");
                    break;
                case 5:
                    Console.WriteLine("Execelente");
                    break;
                default:
                    Console.WriteLine("Nota invalida");
                    break;
            }
            Console.WriteLine("Fim!!");
        }
    }
}
