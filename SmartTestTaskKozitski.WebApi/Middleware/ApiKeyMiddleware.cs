using Microsoft.VisualBasic;
using SmartTestTaskKozitski.BLL.Security;
using System.Net;

namespace SmartTestTaskKozitski.WebApi.Middleware
{
    public class ApiKeyMiddleware
    {
        private readonly RequestDelegate next;
        private readonly IApiKeyValidator apiKeyValidator;

        public ApiKeyMiddleware(RequestDelegate _next, IApiKeyValidator _apiKeyValidator)
        {
            this.next = _next;
            apiKeyValidator = _apiKeyValidator;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string? userApiKey = context.Request.Headers[SmartTestTaskKozitski.BLL.Security.Constants.ApiKeyHeaderName];

            if (string.IsNullOrWhiteSpace(userApiKey))
            {
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return;
            }

            if (!apiKeyValidator.IsValidApiKey(userApiKey))
            {
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                return;
            }

            await next(context);
        }
    }
}
