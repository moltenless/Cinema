using DAL.EF;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Session
    {
        private CinemaContext _context;
        [Key]
        public int Session_id { get; set; }
        public int Hall_id { get; set; }
        public int Session_number { get; set; }
        [StringLength(100)]
        public string Session_name { get; set; }
        [StringLength(200)]
        public string Session_description { get; set; }
        public DateTime Session_date { get; set; }

        //public List<Reservation> Reservations
        //{
        //    get
        //    {
        //        List<Reservation> reservations = new List<Reservation>();
        //        var query = from reservation in _context.Reservation where reservation.Session_id == Session_id select reservation;
        //        foreach (Reservation reservation in query)
        //        {
        //            reservations.Add(reservation);
        //        }
        //        return reservations;
        //    }
        //}

        public Session(int session_id, int hall_id, int session_number, string session_name, string session_description, DateTime session_date, CinemaContext context)
        {
            Session_id = session_id;
            Hall_id = hall_id;
            Session_number = session_number;
            Session_name = session_name;
            Session_description = session_description;
            Session_date = session_date;
            _context = context;
        }

        //public void Reserve(Seat seat, Reservation reservation /* sdf */)
        //{
        //    /*
        //     бронювання місця
        //     */
        //}
    }
}
