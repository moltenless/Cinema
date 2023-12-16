using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Implemetations
{
    internal class SessionRepository : BaseRepository<Session>, ISessionRepository
    {
        public SessionRepository(DbContext context) : base(context)
        {
        }
    }
}
