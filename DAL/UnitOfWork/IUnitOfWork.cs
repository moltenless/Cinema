using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IHallRepository Halls { get; }
        IReservationRepository Reservations { get; }
        ISeatRepository Seats { get; }
        ISessionRepository Sessions { get; }
        IVisitorRepository Visitors { get; }
        void Save();
    }
}
