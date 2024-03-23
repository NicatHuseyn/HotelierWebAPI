using HotelierProject.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Repositories
{
    public interface IReposiotry<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
