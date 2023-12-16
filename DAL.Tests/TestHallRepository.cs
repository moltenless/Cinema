using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories;
using DAL.Repositories.Implemetations;
using Microsoft.EntityFrameworkCore;

namespace DAL.Tests
{
    internal class TestHallRepository : BaseRepository<Hall>
    {
        public TestHallRepository(DbContext context) : base(context)
        {
            _context = context;
            _set = context.Set<Hall>();
        }
    }
}
