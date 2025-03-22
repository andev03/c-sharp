using ModelValidationExample.CustomModelBinders;

namespace ModelValidationExample {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers(options => {
                options.ModelBinderProviders.Insert(0, new PersonBinderProvider);
            });
            builder.Services.AddControllers();
            var app = builder.Build();

            app.UseStaticFiles();
            app.UseRouting();
            app.MapControllers();
            app.Run();
        }
    }
}
