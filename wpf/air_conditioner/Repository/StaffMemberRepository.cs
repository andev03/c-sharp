using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public class StaffMemberRepository {

        private readonly AirConditionerShop2024DBContext _context;

        public StaffMemberRepository() {
            _context = new AirConditionerShop2024DBContext();
        }

        public StaffMember login(string email, string password) {
            return _context.StaffMembers.FirstOrDefault(s => s.EmailAddress == email && s.Password == password);
        }

    }
}
