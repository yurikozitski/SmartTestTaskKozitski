using System.Net;
using System.Text.Json;

namespace SmartTestTaskKozitski.WebApi.Middleware
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<ErrorHandlingMiddleware> logger;

        public ErrorHandlingMiddleware(RequestDelegate _next, ILogger<ErrorHandlingMiddleware> _logger)
        {
            next = _next;
            logger = _logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex, logger);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception ex, ILogger<ErrorHandlingMiddleware> _logger)
        {            
            _logger.LogError(ex, "Server error");

            string message = "Server error occured";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;            
            context.Response.ContentType = "appliation/json";

            var result = JsonSerializer.Serialize(new
            {
                ErrorMessage = message,
            });

            await context.Response.WriteAsync(result);            
        }
    }
}
