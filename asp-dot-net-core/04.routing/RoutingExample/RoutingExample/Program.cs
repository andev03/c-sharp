using RoutingExample.CustomConstraints;

namespace RoutingExample {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddRouting(options => {
                options.ConstraintMap.Add("months", typeof(MonthsCustomConstraint));
            });
            var app = builder.Build();

            app.Use(async (context, next) => {
                Microsoft.AspNetCore.Http.Endpoint? endpoint = context.GetEndpoint();

                if (endpoint != null) {
                    await context.Response.WriteAsync($"Endpoint: {endpoint.DisplayName}");
                }

                await next(context);
            });
            // enable routing
            app.UseRouting();

            _ = app.UseEndpoints(endpoints => {
                // Eg: sales-port/{years}/{month}
                _ = endpoints.Map("sales-port/{years:int:min(1900)}/{month:months}", async context => {
                    string? month = Convert.ToString(context.Request.RouteValues["years"]);
                    string? year = Convert.ToString(context.Request.RouteValues["month"]);


                    await context.Response.WriteAsync($"sales port: - {month} {year}");

                });

                // Path Variables
                _ = endpoints.Map("files/{fileName}.{extension}", async context => {
                    string? filename = Convert.ToString(context.Request.RouteValues["fileName"]);

                    string? extension = Convert.ToString(context.Request.RouteValues[$"extension"]);

                    await context.Response.WriteAsync($"In files - {filename} - {extension}");
                });

                // Optional Parameter
                _ = endpoints.Map("product/productDetail/{id?}", async context => {
                    int id = Convert.ToInt32(context.Request.RouteValues["id"]);

                    await context.Response.WriteAsync($"In files - {id}");
                });

                // Default Parameter
                _ = endpoints.Map("files/profile/{EmployeeName=harsha}", async context => {
                    string? employeeName = Convert.ToString(context.Request.RouteValues["EmployeeName"]);

                    await context.Response.WriteAsync($"In files - {employeeName}");
                });

                // Eg: daily-digest-report/{reportDate}
                _ = endpoints.Map("daily-digest-report/{reportDate:datetime}", async context => {
                    DateTime? reportDate = Convert.ToDateTime(context.Request.RouteValues["reportDate"]);

                    await context.Response.WriteAsync($"In daily-digest-report - {reportDate}");
                });

                // Eg: cities/cityId
                _ = endpoints.Map("cities/{cityId:guid}", async context => {
                    Guid cityId = Guid.Parse(Convert.ToString(context.Request.RouteValues["cityId"])!);

                    await context.Response.WriteAsync($"City information - {cityId}");
                });


                // Eg: post/{postName}
                _ = endpoints.Map("post/{postName:length(3,5)}", async context => {
                    string? postName = Convert.ToString(context.Request.RouteValues["postName"]);

                    await context.Response.WriteAsync($"City information - {postName}");
                });

            });

            // creating end points
            _ = app.UseEndpoints(endpoints => {
                // app end points
                _ = endpoints.MapGet("map1", async (context) => {
                    await context.Response.WriteAsync("In Map 1");
                });

                _ = endpoints.MapPost("map2", async (context) => {
                    await context.Response.WriteAsync("In Map 2");
                });
            });
            app.Run(async context => {
                await context.Response.WriteAsync($"Request received at {context.Request.Path}");
            });
            app.Run();
        }
    }
}
