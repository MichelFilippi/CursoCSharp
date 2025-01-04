using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ControlStatement {
    internal class StructureForEach {
        public static void Execute() {
            string word = "Olá";

            foreach (char letra in word) {
                Console.WriteLine(letra);
            }

            string[] alunos = new string[] { "João","Carlos","Bia","Rafa" };

            foreach (string aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
}
