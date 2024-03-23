using HotelierProject.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<HotelierDbContext>
    {
        public HotelierDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();
            builder.UseSqlServer(Configuration.ConnectionString);
            return new HotelierDbContext(builder.Options);
        }
    }
}
