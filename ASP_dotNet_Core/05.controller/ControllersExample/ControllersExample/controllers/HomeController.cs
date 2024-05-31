using ControllersExample.models;
using Microsoft.AspNetCore.Mvc;

namespace ControllersExample.controllers {

    [Controller]
    public class HomeController : Controller{
        [Route("home")]
        [Route("/")]
        public ContentResult Index() {
/*            return new ContentResult() {
                Content = "Hello from index with content result", ContentType = "text/html"
            };*/

            return Content("Hello from index", "text/plain");
        }


        [Route("person")]
        public JsonResult Person() {
            Person person = new Person() {
                Id = Guid.NewGuid(),
                FirstName = "Nguyen Hoang",
                LastName = "An",
                Age = 21
            };
            return new JsonResult(person);
        }


        [Route("file-dowload")]
        public VirtualFileResult fileDowload() {
            return new VirtualFileResult("/HibernateNote.txt", "application/txt");
        }

        [Route("file-dowload1")]
        public PhysicalFileResult fileDowload2() {
            return new PhysicalFileResult(@"S:\Programming_Language\C#\Practice\ASP_dotNet_Core\05.controller\ControllersExample\ControllersExample\wwwroot\HibernateNote.txt", "application/txt");
        }

        [Route("file-dowload2")]
        public FileContentResult ContractfileDowload3(){

            byte[] bytes = System.IO.File.ReadAllBytes("S:\\Programming_Language\\C#\\Practice\\ASP_dotNet_Core\\05.controller\\ControllersExample\\ControllersExample\\wwwroot\\HibernateNote.txt");
            return new FileContentResult(bytes, "application/txt");
        }
    }
}
