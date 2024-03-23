using HotelierProject.Application.Abstractions.Token;
using HotelierProject.Application.Services.FileServices;
using HotelierProject.Infrastructure.Services.FileServices;
using HotelierProject.Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<ITokenHandler, Infrastructure.Services.Token.TokenHandler>();
            services.AddScoped<IFileService,FileService>();
        }
    }
}
