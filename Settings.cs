using System.Text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace MyWebAPI
{
    public static class Settings
    {
       // public static string Secret = "fedaf7d8863b48e197b9287d492b708e";
        public static void ConfigureServices(WebApplicationBuilder builder)
        {
            var services = builder.Services;
            services.AddCors();
            services.AddControllers();

            var authorApiKey = builder.Configuration.GetValue<string>("AuthorApiKey");
            var key = Encoding.ASCII.GetBytes(authorApiKey);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
        }
    }
}