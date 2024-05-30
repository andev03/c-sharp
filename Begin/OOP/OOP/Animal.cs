using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP {
    public class Animal {

        private int weight;

        private int height;

        public int Weight {
            get => weight;
            set => weight = value;
        }
        public int Height {
            get => height;
            set => height = value;
        }

        public Animal() {
        }

        public Animal(int weight, int height) {
            Weight = weight;
            Height = height;
        }

        public virtual String infor() {
            return $"Hello Animal {Weight} {Height}";
        }

    }
}
