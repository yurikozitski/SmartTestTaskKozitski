using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTestTaskKozitski.BLL.Security
{
    public class ApiKeyValidator : IApiKeyValidator
    {
        private readonly IConfiguration configuration;

        public ApiKeyValidator(IConfiguration _configuration)
        {
            this.configuration = _configuration;
        }

        public bool IsValidApiKey(string userApiKey)
        {
            if (string.IsNullOrWhiteSpace(userApiKey))
            {
                return false;
            }
            
            string? apiKey = configuration[Constants.ApiKeyName];

            if (apiKey == null || !string.Equals(apiKey, userApiKey, StringComparison.InvariantCulture))
            {
                return false;
            }

            return true;
        }
    }
}
