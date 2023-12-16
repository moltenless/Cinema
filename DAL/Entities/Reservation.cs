using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Reservation
    {
        [Key]
        public int Reservation_id { get; set; }
        public int Session_id { get; set; }
        public int Reservation_number { get; set; }
        public int Session_number { get; set; }
        public int Seat_id { get; set; }
        public int Visitor_id { get; set; }

        public Reservation(int reservation_id, int session_id, int reservation_number, int session_number, int seat_id, int visitor_id)
        {
            Reservation_id = reservation_id;
            Session_id = session_id;
            Reservation_number = reservation_number;
            Session_number = session_number;
            Seat_id = seat_id;
            Visitor_id = visitor_id;
        }
    }
}
