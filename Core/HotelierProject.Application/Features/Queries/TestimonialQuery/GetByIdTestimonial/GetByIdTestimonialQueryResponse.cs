using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Features.Queries.TestimonialQuery.GetByIdTestimonial
{
    public class GetByIdTestimonialQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
