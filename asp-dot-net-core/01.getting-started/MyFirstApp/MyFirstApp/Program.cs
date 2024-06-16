using Microsoft.Extensions.Primitives;

namespace MyFirstApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.Run(async (HttpContext context) => {
                System.IO.StreamReader reader = new StreamReader(context.Request.Body);
                String body = await reader.ReadToEndAsync();

                Dictionary<string, StringValues> queryDict = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(body);
                if (queryDict.ContainsKey("firstName")) {
                    string firstName = queryDict["firstName"][10];
                    await context.Response.WriteAsync(firstName);
                }
              
            });

            app.Run();
        }
    }
}
