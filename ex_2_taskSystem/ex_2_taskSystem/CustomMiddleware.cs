using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ex_2_taskSystem
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CustomMiddleware
    {
        private readonly RequestDelegate request;

        public CustomMiddleware(RequestDelegate request)
        {
            this.request = request;
        }

        public Task Invoke(HttpContext httpContext)
        {
            Console.WriteLine("accacacac");
            return httpContext.Response.WriteAsync("rtrtrtrtrt");

            //return this.request(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CustomMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomMiddleware>();
        }
    }
}
