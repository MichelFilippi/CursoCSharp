using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassMethod {

    public class Prod {
        public string Name;
        public double Price;
        public double Discount;

    public Prod(string name, double price, double discount) { 
            Name = name;
            Price = price;
            Discount = discount;
        }
    public Prod() {

        }
    public double CalcDiscount() {
            return Price - Price * Discount;
        }



     internal class AtribStatic {
           public static void Execute() {

                var prod1 = new Prod("Caneta", 2.0, 0.40);
                var prod2 = new Prod("Caderno", 10.90, 0.10);

                Console.WriteLine(prod1.Name);
                Console.WriteLine(prod2.Name);
                Console.WriteLine(prod1.CalcDiscount());
            }
        }
    }
}
