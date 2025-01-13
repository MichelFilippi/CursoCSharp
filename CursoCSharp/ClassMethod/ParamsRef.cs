using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassMethod {
    internal class ParamsRef {

         double calcularMedia(double nota1, double nota2, double nota3, String conc) {
            double media = (nota1 + nota2 + nota3)/ 3;
            conc = media >= 7.00 ? "Aprovado" : "Reprovado";
            return media;
        }

        public static void ChangeRef(ref int num) {
            num = num + 1000;
        }
        public static void ChangeOut(out int num1, out int num2) {
            num1 = 0;
            num2 = 0;
            num1 = num1 + 15;
            num2 = num2 + 30;

        }
        public static void Execute() {
            int a = 3;
            ChangeRef(ref a);
            Console.WriteLine(a);


            ChangeOut(out int b, out int c);
            Console.WriteLine($"{b} {c}");

           

            




        }

    }
}
