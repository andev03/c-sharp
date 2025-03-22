using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
    class Employee {
        private int id;
        private string name;

        // Constructor
        public Employee(int id, string name) {
            this.Id = id;
            this.Name = name;
        }

        // Properties
        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public int Id {
            get {
                return id;
            }
            set {
                id = value;
            }
        }
    }
}
