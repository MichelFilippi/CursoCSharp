using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colections {
    internal class DictionaryC {
        public static void Execute() {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2002, "Homem aranha");
            filmes.Add(2000, "Gladiador");
            filmes.Add(2004, "Os Incriveis");

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: " + filmes[2004]);
                
            }

            Console.WriteLine(filmes.ContainsValue("Amnesia"));
            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            filmes.TryGetValue(2000, out string filme2000);
            Console.WriteLine($"Filme {filme2000}!");

            foreach (var key in filmes.Keys) {
                Console.WriteLine(key);
            }

            foreach (var valor in filmes.Values) {
                Console.WriteLine(valor);
            }

            foreach(KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é do ano {filme.Key}");
            }

            foreach (var filme in filmes) {
                Console.WriteLine($"{filme.Value} é do ano {filme.Key}");
            }

        }
    }
}
