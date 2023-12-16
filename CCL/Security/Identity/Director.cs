using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCL.Security.Identity
{
    public class Director : User
    {
        public Director(int userId, string name, int v)
        : base(userId, name, nameof(Director))
        { }
    }
}
