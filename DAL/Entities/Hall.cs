using DAL.EF;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Hall
    {
        private CinemaContext _context;
        [Key]
        public int Hall_id { get; set; }
        public int Hall_number { get; set; }
        //public List<Seat> Seats
        //{
        //    get
        //    {
        //        List<Seat> seats = new List<Seat>();
        //        var query = from seat in _context.Seat where seat.Hall_id == Hall_id select seat;
        //        foreach (Seat seat in query)
        //        {
        //            seats.Add(seat);
        //        }
        //        return seats;
        //    }
        //}

        public Hall(int hall_id, int hall_number, CinemaContext context)
        {
            Hall_id = hall_id;
            Hall_number = hall_number;
            _context = context;
        }

        //public void AutoFillPrices()
        //{
        //    foreach(var seat in Seats)
        //    {
        //        _context.Seat.Remove(_context.Seat.Find(seat.Seat_id));
        //    }

        //    for (int i = 0; i < 10; i++)
        //    {
        //        Seat seat = new Seat(i + 1, Hall_id, i + 1, (i + 1) * 10, 0);
        //        _context.Seat.Add(seat);
        //    }
        //}

    }
}
