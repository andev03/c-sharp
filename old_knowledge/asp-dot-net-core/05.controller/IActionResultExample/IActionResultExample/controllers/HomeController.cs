using Microsoft.AspNetCore.Mvc;

namespace IActionResultExample.controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            if (!Request.Query.ContainsKey("bookId")) {
                Response.StatusCode = 400;
                return Content("Book Id is not supplied");
            }

            //Book id can't be empty
            if (string.IsNullOrEmpty(Convert.ToString(Request.Query["bookId"]))) {
                Response.StatusCode = 400;
                return Content("Book id can't be null or empty");
            }

            // Book id should beetween 1 to 1000
            int bookId = Convert.ToInt16(ControllerContext.HttpContext.Request.Query["bookId"]);

            if (bookId <= 0 || bookId > 1000) {
                Response.StatusCode = 400;
                return Content("bookId can't be less then or equal to zero or greater than 1000");
            }

            return File("/HibernateNote.txt", "application/plain");
        }
    }
}
