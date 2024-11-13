using WebAPI.Middleware;

namespace WebAPI.Extensions
{
    public static class AppExtensions
    {
        public static void UseErrorHandleingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}