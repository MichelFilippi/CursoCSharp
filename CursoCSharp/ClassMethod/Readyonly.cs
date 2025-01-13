using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassMethod {
    public class Client {
        public string Name;
        readonly DateTime Birth;

        public Client(string name, DateTime birth) {
            Name = name;
            Birth = birth;
        }
        public string GetBirth() {
            return String.Format("{0}/{1}/{2}", Birth.Day, Birth.Month, Birth.Year);
        }

        internal class Readyonly {
            public static void Execute() {
                var newClient = new Client("Mario", new DateTime(1987, 6, 22));

                Console.WriteLine(newClient.Name);
                Console.WriteLine(newClient.GetBirth());
            }
        }
    }
}
