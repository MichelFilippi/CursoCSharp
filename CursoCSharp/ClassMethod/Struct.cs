using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassMethod {

    interface Dot {
        void MoveDiagonally(int delta);
    }
    struct Coord: Dot {
        public int X;
        public int Y;

        public Coord(int x, int y) {
            X = x;
            Y = y;
        }

        public void MoveDiagonally(int delta) {
            X += delta;
            Y += delta;
        }

    }


    internal class Struct {
        public static void Execute() {
            Coord coord;
            coord.X = 3;
            coord.Y = 3;

            Console.WriteLine(coord);


        }
    }
}
