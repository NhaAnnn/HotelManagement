using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Model
{
    public class Room
    {
        public string nameRoom { get; set; }
        public string typeRoom { get; set; }
        public int capacityRoom { get; set; }
        public decimal priceRoom { get; set; }
        public string statusRoom { get; set; }
    }
}
