using MiddlewareExample.CustomMiddleware;

namespace MiddlewareExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<MyCustomMiddleware>();

            var app = builder.Build();
            // middleware 1
            app.Use(async (HttpContext context, RequestDelegate next) => {
                await context.Response.WriteAsync("Hello");
                await next(context);
            });

            // middleware 2
            //app.UseMyCustomMiddleware();
            app.UseHelloMyCustomMiddleware();
            
            // middleware 3
            app.Run(async (HttpContext context) => {
                await context.Response.WriteAsync("Hello again");
            });

            app.Run();
        }
    }
}
