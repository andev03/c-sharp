using Microsoft.Extensions.FileProviders;

namespace StaticFilesExample {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(new WebApplicationOptions {
                WebRootPath = "myroot"
            });
            var app = builder.Build();

            app.UseStaticFiles(new StaticFileOptions() {
                FileProvider = new PhysicalFileProvider(
                   Path.Combine(builder.Environment.ContentRootPath, "myroot"))
            }); //works the web root path (myroot)

            app.UseRouting();

            app.UseEndpoints(endpoints => {
                _ = endpoints.Map("/", async context => {
                    await context.Response.WriteAsync("Hello");
                });
            });
            app.Run();
        }
    }
}
