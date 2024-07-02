using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract {
    public abstract class Shape {
        public int Height {
            get; set;
        }
        public int Width {
            get; set;
        }

        // Virtual method
        public virtual void Draw() {
            Console.WriteLine("Performing base class Drawing tasks");
        }

        public void Print() {
            Console.WriteLine("Performing base class Printing tasks");
        }

        // Abstract method
        public abstract void Display();
    }
}
