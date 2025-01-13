using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassMethod {
    internal class Params {

        public static void Recep(params string[] pessoas) {
            foreach (var pessoa in pessoas) {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }
        public static void Execute() {
            Recep("Pedro", "Manu", "Joao", "Carlos");
        }
    }
}
