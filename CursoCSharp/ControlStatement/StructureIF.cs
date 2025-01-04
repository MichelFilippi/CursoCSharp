using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ControlStatement {
    internal class StructureIF {
        public static void Execute() {
            bool goodBehavior = false;
            string input;

            Console.Write("Digite a nota do aluno: ");
            input= Console.ReadLine();
            Double.TryParse(input, out double grade);

            Console.WriteLine("Possui bom comportamento (S/N)");
            input = Console.ReadLine();

            //if (input == "s"|| input == "S") 
            //    goodBehavior = true;
            goodBehavior = input.ToUpper() == "S";
            
            if (grade >= 9.0 && goodBehavior) {
                Console.WriteLine("Parabens");
            };


           
          

        }
    }
}
