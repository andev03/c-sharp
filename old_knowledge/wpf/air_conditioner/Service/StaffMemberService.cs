using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service {
    public class StaffMemberService {

        private readonly StaffMemberRepository staffMemberRepository;

        public StaffMemberService() {
            this.staffMemberRepository = new StaffMemberRepository();
        }

        public StaffMember login(string username, string password) {
            return staffMemberRepository.login(username, password);
        }
    }
}
