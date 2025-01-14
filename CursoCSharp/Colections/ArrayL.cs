using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colections {
    internal class ArrayL {
        public static void Execute() {
            var arraylist1 = new ArrayList { 3, "Nome", true };

            arraylist1.Add(3.14);

            foreach (var item in arraylist1) {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }

        }
    }
}


