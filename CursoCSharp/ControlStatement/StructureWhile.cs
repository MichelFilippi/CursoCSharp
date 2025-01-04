using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ControlStatement {
    internal class StructureWhile {
        public static void Execute() {
            int guess = 0;
            Random random = new Random();

            int secretNumber = random.Next(1, 16);
            bool foundNumber = false;
            int remainingAtt = 5;
            int att = 0;

            while (remainingAtt > 0 && !foundNumber) {
                Console.WriteLine("Coloque seu palpite: ");
                string inputAtt = Console.ReadLine();
                int.TryParse(inputAtt, out guess);

                att++;
                remainingAtt--;

                if (secretNumber == guess) {
                    foundNumber = true;
                    var prevColor = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("O numero foi encontrado em {0} tentativas", guess);
                    Console.BackgroundColor = prevColor;
                } else if (secretNumber < guess) {
                    Console.WriteLine("O número é menor");
                    Console.WriteLine("Tentativas restantes: {0}",remainingAtt);
                } else if (secretNumber > guess) {
                    Console.WriteLine("O número é maior");
                    Console.WriteLine("Tentativas restantes: {0}", remainingAtt);
                }
            }
        }
    }
}
