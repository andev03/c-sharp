using LoginUsingMiddleware.CustomMiddleware;

namespace LoginUsingMiddleware
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.UseLoginMiddleware();

            app.Run(async context =>
            {
                await context.Response.WriteAsync("No response");
            });
            app.Run();
        }
    }
}
