using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.DTO.DTOs.RoomDtos
{
    public class AddRoomDto
    {
        public string RoomCoverImage { get; set; }
        public string RoomNumber { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
        public int BedCount { get; set; }
        public int BathCount { get; set; }
        public string Description { get; set; }
    }
}
