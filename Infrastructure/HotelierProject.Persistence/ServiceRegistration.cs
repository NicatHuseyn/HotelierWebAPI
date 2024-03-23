using HotelierProject.Application.Repositories;
using HotelierProject.Domain.Entities.Identity;
using HotelierProject.Persistence.Contexts;
using HotelierProject.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddDbContext<HotelierDbContext>(option=>option.UseSqlServer(Configuration.ConnectionString));

            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 3;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                
            }).AddEntityFrameworkStores<HotelierDbContext>();

            services.AddScoped<IRoomReadRepository,RoomReadRepository>();
            services.AddScoped<IRoomWriteRepository,RoomWriteRepository>();

            services.AddScoped<IServiceReadRepository, ServiceReadRepository>();
            services.AddScoped<IServiceWriteRepository, ServiceWriteRepository>();

            services.AddScoped<IStaffReadRepository, StaffReadRepository>();
            services.AddScoped<IStaffWriteRepository, StaffWriteRepository>();

            services.AddScoped<ITestimonialReadRepository, TestimonialReadRepository>();
            services.AddScoped<ITestimonialWriteRepository, TestimonialWriteRepository>();
        }
    }
}
