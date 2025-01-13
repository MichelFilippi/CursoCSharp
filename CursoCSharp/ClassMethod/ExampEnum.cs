using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassMethod {
    internal class ExampEnum {
        public enum Genero {Acao, Aventura, Terror, Animacao, Comedia };

        public class Movie {
            public string Title;
            public Genero GeneroDoFilme;
        }
        public static void Execute() {
            int id = (int)Genero.Terror;
            Console.WriteLine(id);

            var FreeMovie = new Movie();
            FreeMovie.Title = "Meu Malvado favorito 7";
            FreeMovie.GeneroDoFilme = Genero.Animacao;

            Console.WriteLine("{0} é meu filme preferido", FreeMovie.Title );
            Console.WriteLine(FreeMovie.GeneroDoFilme);

        }
    }
}
