using DAL.EF;
using DAL.Entities;

namespace DAL.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            using (CinemaContext context = new CinemaContext())
            {
                context.Hall.Add(new Hall (1,15, context));
                context.Seat.Add(new Seat(1, 1, 23, 300, 0));
                context.SaveChanges();

                context.Session.Add(new Session (1, 1, 54, "Matrix", "Incredible movie", new DateTime(2023, 12, 8), context));
                context.SaveChanges();

                context.Visitor.Add(new Visitor(1, "Serhii", 0.05));
                context.SaveChanges();
                context.Reservation.Add(new Reservation(1, 1, 132, 54, 1, 1));
                context.SaveChanges();
            }
        }
    }
}