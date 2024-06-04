using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
namespace DependencyInjectionExample.Controllers {
    public class HomeController : Controller {

        private readonly ICitiesService _citiesService;

        public HomeController([FromServices]ICitiesService citiesService) {
            // create object of CitiesService class
            _citiesService = citiesService;//new CitiesService();
        }
        [Route("/")]
        public IActionResult Index() {
            List<string>? cities = _citiesService.GetCities();
            return View(cities);
        }
    }
}
