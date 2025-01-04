using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ControlStatement {
    internal class StructureFor {
        public static void Execute() {

            // for (int i = 1; i <= 10;i ++) {
            //  Console.WriteLine($"O valor de i é {i}");


            double summ = 0;
            string input;

            Console.WriteLine("Informe o tamanho da turma");
            input = Console.ReadLine();
            int.TryParse(input, out int classSize);

            for (int i = 1; i <= classSize; i++) {
                Console.WriteLine("Informe a nota do aluno {0}", i);
                input = Console.ReadLine();
                double.TryParse(input, out double value);

                summ += value;
            }
            double mean = classSize > 0 ? summ/ classSize : 0;
            Console.WriteLine("A média da turma é: {0}", mean);
        }
    }
}
