using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract {
    class Program {
        static void Main(string[] args) {
            Shape p = new Circle();
            p.Display();
            p.Draw();
            p = new Rectangle();
            p.Display();
            p.Draw();
            p.Print();
            Console.ReadLine();
        }
    }
}
