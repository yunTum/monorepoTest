using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace APICore.Utility
{
    public class CorsPolicy
    {
        public void ConfigureCors(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                    builder => builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });
        }
        public void UseCors(IApplicationBuilder app)
        {
            app.UseCors("AllowSpecificOrigin");
        }
    }
}
