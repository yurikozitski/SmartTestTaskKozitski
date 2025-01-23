using Microsoft.OpenApi.Models;
using SmartTestTaskKozitski.BLL.Security;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace SmartTestTaskKozitski.WebApi.Swagger
{
    public class CustomHeaderParameter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            operation.Parameters =
            [
                new OpenApiParameter
                {
                    Name = Constants.ApiKeyHeaderName,
                    In = ParameterLocation.Header,
                    Description = "Api key header",
                    Required = true
                },
            ];
        }
    }
}
