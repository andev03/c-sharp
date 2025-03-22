using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service {
    public class AirConditionerService {

        private readonly AirConditionerRepository airConditionerRepository;
        private readonly AirConditionerShop2024DBContext _context;
        private readonly DataAccessObject<AirConditioner> dataAccessObject;
        public AirConditionerService() {
            airConditionerRepository = new AirConditionerRepository();
            dataAccessObject = new DataAccessObject<AirConditioner>();
        }

        public List<AirConditioner> getAll() {
            return airConditionerRepository.getAll();
        }

        public List<AirConditioner> searchAir(string featureFunction, int quantity, bool isVaid) {
            return airConditionerRepository.searchAir(featureFunction, quantity, isVaid);
        }

        public void deleteAirConditionder(int id) {
            airConditionerRepository.deleteAirConditionder(id);
        }
    }
}
