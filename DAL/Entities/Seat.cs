using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Seat
    {
        [Key]
        public int Seat_id { get; set; }
        public int Hall_id { get; set; }
        public int Seat_number { get; set; }
        public double Price { get; set; }
        public int Reserved { get; set; }

        public Seat(int seat_id, int hall_id, int seat_number, double price, int reserved)
        {
            Seat_id = seat_id;
            Hall_id = hall_id;
            Seat_number = seat_number;
            Price = price;
            Reserved = reserved;
        }
    }
}
