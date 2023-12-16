using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class SessionDTO
    {
        public int Session_id { get; set; }
        public int Hall_id { get; set; }
        public int Session_number { get; set; }
        public string Session_name { get; set; }
        public string Session_description { get; set; }
        public DateTime Session_date { get; set; }
    }
}
