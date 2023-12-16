using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCL.Security.Identity
{
    public class Accountant : User
    {
        public Accountant(int userId, string name)
        : base(userId, name, nameof(Accountant))
        { }
    }
}
