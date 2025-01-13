using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassMethod {
    internal class People {
        public string name;
        public int age;

        public string ShowMe() {

            return string.Format($"Olá sou o {name} e tenho {age}. ");
        }
        public void ShowAll() {
            Console.WriteLine(ShowMe());    
        }
    }
}
