using Microsoft.AspNetCore.Mvc;

namespace IActionResultExample.controllers {
    public class StoreController : Controller {
        [Route("redirect-to-google")]
        public IActionResult RedirectToGoogle() {
            return Redirect("https://www.google.com");
        }

        // Chuyển hướng đến một hành động khác trong cùng controller
        [Route("redirect-to-about")]
        public IActionResult RedirectToAbout() {
            return RedirectToAction("About");
        }

        // Chuyển hướng đến một hành động trong một controller khác
        [Route("redirect-to-contact")]
        public IActionResult RedirectToContact() {
            return RedirectToAction("Contact", "Support");
        }

        // Chuyển hướng đến một route cụ thể
        [Route("redirect-to-privacy")]
        public IActionResult RedirectToPrivacy() {
            return RedirectToRoute(new {
                controller = "Home", action = "Privacy"
            });
        }

        // Ví dụ về các hành động đích
        [Route("about")]
        public IActionResult About() {
            return View();
        }

        [Route("contact")]
        public IActionResult Contact() {
            return View();
        }

        [Route("privacy")]
        public IActionResult Privacy() {
            return View();
        }
    }
}
