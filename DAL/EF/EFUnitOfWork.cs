using DAL.Repositories.Implemetations;
using DAL.Repositories.Interfaces;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    internal class EFUnitOfWork : IUnitOfWork
    {
        private CinemaContext db;
        private HallRepository hallRepository;
        private ReservationRepository reservationRepository;
        private SeatRepository seatRepository;
        private SessionRepository sessionRepository;
        private VisitorRepository visitorRepository;

        public EFUnitOfWork()
        {
            db = new CinemaContext();
        }

        public IHallRepository Halls
        {
            get
            {
                if (hallRepository == null)
                    hallRepository = new HallRepository(db);
                return hallRepository;
            }
        }

    public IReservationRepository Reservations
        {
            get
            {
                if (reservationRepository == null)
                    reservationRepository = new ReservationRepository(db);
                return reservationRepository;
            }
        }

        public ISeatRepository Seats
        {
            get
            {
                if (seatRepository == null)
                    seatRepository = new SeatRepository(db);
                return seatRepository;
            }
        }

        public ISessionRepository Sessions
        {
            get
            {
                if (sessionRepository == null)
                    sessionRepository = new SessionRepository(db);
                return sessionRepository;
            }
        }

        public IVisitorRepository Visitors
        {
            get
            {
                if (visitorRepository == null)
                    visitorRepository = new VisitorRepository(db);
                return visitorRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
