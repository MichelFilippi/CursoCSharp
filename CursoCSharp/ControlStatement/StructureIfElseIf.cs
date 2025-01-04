using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ControlStatement {
    internal class StructureIfElseIf {
        public static void Execute() {
            Console.Write("Digite a nota do aluno: ");

            string input = Console.ReadLine();
            Double.TryParse(input, out double value);

            if (value >= 9.0) {
                Console.WriteLine("Quadro de honra");
            } else
                if(value >=7.0 && value < 9.0){
                    Console.WriteLine("Passou");
                } else {
                    Console.WriteLine("Reprovado");
                }

        }
    }
}
