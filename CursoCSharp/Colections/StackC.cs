using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colections {
    internal class StackC {
        public static void Execute() {
            var pilha = new Stack();
            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(3.14f);
            pilha.Push(true);

            foreach (var item in pilha) {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha) {
                Console.Write($"{item} ");
            }


        }
    }
}
