using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
    class Program {
        static void Main(string[] args) {
            Manager jack = new Manager(1000, "Jack", "Jack@gmail.com");
            Console.WriteLine(jack);
            Console.ReadLine();
        }
    }
}
