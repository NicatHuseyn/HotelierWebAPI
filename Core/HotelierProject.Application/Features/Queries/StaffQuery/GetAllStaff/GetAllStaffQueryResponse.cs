using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Queries.StaffQuery.GetAllStaff
{
    public class GetAllStaffQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profeesion { get; set; }
        public string FaceBookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
    }
}
