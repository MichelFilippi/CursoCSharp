using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colections {
    internal class QueueC {
        public static void Execute() {
            var fila = new Queue<string>();

            fila.Enqueue("Carlos");
            fila.Enqueue("Joao");
            fila.Enqueue("Michel");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);

                var fila2 = new Queue();
                fila2.Enqueue("Junior");
                fila2.Enqueue(3.14);

                Console.WriteLine(fila2.Contains("junior"));
            }
        }
    }
}
