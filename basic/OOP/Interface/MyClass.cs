using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface {
    public class MyClass : IFirst, ISecond {
        public void Display() {
            Console.WriteLine("Display method");
        }

        void IFirst.Print() {
            Console.WriteLine("IFirst's Print method.");
        }

        void ISecond.Print() {
            Console.WriteLine("ISecond's Print method.");
        }
    }
}
