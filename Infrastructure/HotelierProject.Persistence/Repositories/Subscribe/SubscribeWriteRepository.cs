using HotelierProject.Application.Repositories;
using HotelierProject.Domain.Entities;
using HotelierProject.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Persistence.Repositories
{
    public class SubscribeWriteRepository : WriteRepository<Subscribe>, ISubscribeWriteRepository
    {
        public SubscribeWriteRepository(HotelierDbContext context) : base(context)
        {
        }
    }
}
