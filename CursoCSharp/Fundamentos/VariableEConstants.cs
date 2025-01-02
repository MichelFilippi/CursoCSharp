using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class VariableEConstants {

        public static void Execute() {

            double raio = 4.5;
            const double pi = 3.14;

            double area = pi * raio *raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é " + area);

            bool itsRaining = true;
            Console.WriteLine("Está chovendo? " +itsRaining);

            byte idade = 45;
            Console.WriteLine("Minha idade é "+idade);

            sbyte qtd = sbyte.MinValue;
            Console.WriteLine(qtd);

            short salario = short.MaxValue;
            Console.WriteLine(salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine(menorValorInt);

            uint populacaoBrasil = 207_600_000;
            Console.WriteLine(populacaoBrasil);

            long menorvalorLong = long.MinValue;
            Console.WriteLine(menorvalorLong);

            ulong populacaoMundo = 7_600_000_000;
            Console.WriteLine(populacaoMundo);

            float precoComputador = 1299.99F;
            Console.WriteLine(precoComputador);

            double valorApple = 100000000000;
            Console.WriteLine(valorApple);

            decimal distanciaAstros = decimal.MaxValue;
            Console.WriteLine(distanciaAstros);

            char letra = 'a';
            Console.WriteLine(letra);





        }
    }
}
