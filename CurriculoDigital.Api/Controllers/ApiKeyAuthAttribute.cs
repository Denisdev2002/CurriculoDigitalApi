using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;

namespace CurriculoDigital.Api.Controllers
{
    public class ApiKeyAuthAttribute : Attribute, IAuthorizationFilter
    {
        private const string API_KEY_HEADER_NAME = "API-KEY";

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var configuration = context.HttpContext.RequestServices.GetService(typeof(IConfiguration)) as IConfiguration;

            var expectedApiKey = configuration.GetValue<string>("ApiSettings:ApiKey");

            if (!context.HttpContext.Request.Headers.TryGetValue(API_KEY_HEADER_NAME, out var extractedApiKey))
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            if (!expectedApiKey.Equals(extractedApiKey))
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}