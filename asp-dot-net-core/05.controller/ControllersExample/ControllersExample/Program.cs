namespace ControllersExample {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers(); // add controller classes as services
            var app = builder.Build();

            app.UseStaticFiles();

            app.UseRouting();

            _ = app.UseEndpoints(endpoints => {
                _ = endpoints.MapControllers();
            });
            app.Run();
        }
    }
}
