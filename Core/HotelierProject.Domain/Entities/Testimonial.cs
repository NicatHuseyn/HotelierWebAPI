using HotelierProject.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Domain.Entities
{
    public class Testimonial:BaseEntity
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
