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
    internal class SeatRepository : BaseRepository<Seat>, ISeatRepository
    {
        public SeatRepository(DbContext context) : base(context)
        {
        }
    }
}
