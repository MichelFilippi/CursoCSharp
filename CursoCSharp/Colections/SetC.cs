using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colections {
    internal class SetC {
        public static void Execute() {
            var livro = new Produto("Harry potter", 10.90);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("Filme 7 parte 1", 80.90),
                new Produto("Poster", 10),
                new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            

            foreach(var item in carrinho) {
               
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);



        }
    }
}
