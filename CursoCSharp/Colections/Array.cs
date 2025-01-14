using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colections {
    internal class Array {
        public static void Execute() {
            string[] aluno = new string[5];
            aluno[0] = "Jão";
            aluno[1] = "Carlos";
            aluno[2] = "Leonardo";
            aluno[3] = "Guilherme";
            aluno[4] = "Marcos";
            
           foreach (var alunos in aluno) {
                Console.WriteLine(alunos);
            }

            double somatorio = 0;
            double[] nota= { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var notas in nota) {
                somatorio += notas;
            }
            
            //for (int i = 0; i < nota.Length; i++) {
            //    somatorio = nota[i];
            //}

            double media = somatorio /nota.Length;

            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
