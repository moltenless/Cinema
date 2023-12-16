using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class SeatDTO
    {
        public int Seat_id { get; set; }
        public int Hall_id { get; set; }
        public int Seat_number { get; set; }
        public double Price { get; set; }
        public int Reserved { get; set; }
    }
}
