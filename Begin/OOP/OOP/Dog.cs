using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP {
    public class Dog : Animal {

        private String nameDog;

        public Dog() {
        }

        public string NameDog {
            get => nameDog;
            set => nameDog = value;
        }

        public override string infor() {
            return "Hello Dog";
        }
    }
}
