using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassMethod {
    public class CarOption {
        double discount = 0.1;
        string name;
        public string Name {
            get {
               return  "Opcional: " + name;
            }
            set {
                name = value;
            }
        }
        public double Price { get; set; }

        public double PrinceDiscount {
            get => Price - (discount * Price);
        }

        public CarOption() {

        }
        public CarOption(string name,double price) {
            this.Name = name;
            this.Price = price;
        }


    }
    internal class Props {
        public static void Execute() {
            var op1 = new CarOption("Ar condicionado", 1999.90);
            Console.WriteLine(op1.PrinceDiscount);
        }
    }
}
