using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    internal class StructureIfElse {
        public static void Execute() {
            double grade = 7.0;

            if(grade>= 7.0) {

                Console.WriteLine("Aprovado");
                Console.WriteLine("Não fez mais que a obrigação");
            } else {
                Console.WriteLine("Recuperação");
            }
        }
    }
}
