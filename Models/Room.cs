using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelWebsite.Models
{
    public class Room
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public Boolean Vacant { get; set; }
        public decimal Price { get; set; }
    }
}
