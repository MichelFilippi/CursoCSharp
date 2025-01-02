using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class NotacaoPonto {
        public static void Execute() {

            string saudacao = "ola".ToUpper().Insert(3, " World").Replace(" World"," Mundo");
            Console.WriteLine(saudacao);

            string valorGrande = null;
            Console.WriteLine(valorGrande?.Length);

        }
    }
}
