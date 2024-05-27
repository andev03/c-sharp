using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MiddlewareExample.CustomMiddleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class HelloMyCustomMiddleware
    {
        private readonly RequestDelegate _next;

        public HelloMyCustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Request.Query.ContainsKey("firstName") && httpContext.Request.Query.ContainsKey("lastName"))
            {
                string fullName = httpContext.Request.Query["firstName"] + " " + httpContext.Request.Query["lastName"];
                httpContext.Response.WriteAsync(fullName);

            };
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class HelloMyCustomMiddlewareExtensions
    {
        public static IApplicationBuilder UseHelloMyCustomMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HelloMyCustomMiddleware>();
        }
    }
}
