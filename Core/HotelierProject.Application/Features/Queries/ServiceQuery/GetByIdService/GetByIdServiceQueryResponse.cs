using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Queries.ServiceQuery.GetByIdService
{
    public class GetByIdServiceQueryResponse
    {
        public int Id { get; set; }
        public string IconUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
