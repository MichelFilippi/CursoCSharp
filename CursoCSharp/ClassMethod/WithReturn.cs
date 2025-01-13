using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassMethod {

    class TestCal {
        public int Add(int a, int b) {
            return a + b;
        }
    }
    class calculadoraCadeia {
        int memoria;

        public calculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }
        public calculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }
        public calculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }
        public calculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        internal class WithReturn {

            public static void Execute() {
                var calculadoraCadeia = new calculadoraCadeia();
                calculadoraCadeia.Somar(3).Multiplicar(5).Imprimir();
            }
        }
    }
}
