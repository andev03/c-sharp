using Microsoft.AspNetCore.Mvc;
using ModelValidationExample.models;
namespace ModelValidationExample.controllers {
    public class HomeController : Controller {
        [Route("register")]
        public IActionResult Index(Person person) {
            return Content($"{person}");
        }
    }
}
