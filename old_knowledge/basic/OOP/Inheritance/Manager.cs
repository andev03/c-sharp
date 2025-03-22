using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
    class Manager : Employee {
        private string email;

        public Manager(int id, string name, string email) : base(id, name) {
            this.Email = email;
        }

        public string Email {
            get {
                return email;
            }
            set {
                email = value;
            }
        }

        public override string ToString() {
            return $"Id: {Id}, Name: {Name}, Email: {Email}";
        }
    }


}
