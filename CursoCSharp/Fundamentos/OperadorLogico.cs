using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadorLogico {
        public static   void Execute() {
            bool executouTrab1 = false;
            bool executouTrab2 = false;

            bool comprouCasa = executouTrab1 && executouTrab2;
            Console.WriteLine("Comprou a casa? {0}", comprouCasa);
            
            bool comprouCarro = executouTrab1 || executouTrab2;
            Console.WriteLine("Comprou o carro? {0}", comprouCarro);

            bool comprouMoto = executouTrab1 ^ executouTrab2;
            Console.WriteLine("Comprou a moto? {0}",comprouMoto);

            Console.WriteLine("Vai economizar na gasolina ? {0}", !comprouCarro || !comprouMoto);
        }
    }
}
