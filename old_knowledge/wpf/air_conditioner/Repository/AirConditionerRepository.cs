using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public class AirConditionerRepository {

        private readonly AirConditionerShop2024DBContext _context;

        private readonly DataAccessObject<AirConditioner> dataAccessObject;
        public AirConditionerRepository() {
            _context = new AirConditionerShop2024DBContext();
            dataAccessObject = new DataAccessObject<AirConditioner>();
        }
        public List<AirConditioner> getAll() {
            return _context.AirConditioners.Include(ac => ac.Supplier).ToList();
        }

        public List<AirConditioner> searchAir(string featureFunction, int quantity, bool isValid) {
            if (featureFunction.IsNullOrEmpty()) {
                return _context.AirConditioners.Where(air => air.Quantity == quantity).ToList();
            } else if (isValid){
                return _context.AirConditioners.Where(air => air.FeatureFunction.Contains(featureFunction)).ToList();
            }
            return _context.AirConditioners.Where(air => air.FeatureFunction.Contains(featureFunction) || air.Quantity == quantity).ToList();
        }

        public void deleteAirConditionder(int id) {
            AirConditioner airConditioner = dataAccessObject.GetById(id);

            dataAccessObject.Remove(airConditioner);
        }
    }
}
