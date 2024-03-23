using HotelierProject.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Domain.Entities
{
    public class Subscribe:BaseEntity
    {
        public string MailAddress { get; set; }
    }
}
