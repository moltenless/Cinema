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
    internal class HallRepository : BaseRepository<Hall>, IHallRepository
    {
        public HallRepository(DbContext context) : base(context)
        {
        }
    }
}
