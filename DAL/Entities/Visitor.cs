using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Visitor
    {
        [Key]
        public int Visitor_id { get; set; }
        [StringLength(100)]
        public string Visitor_name { get; set; }
        public double Discount { get; set; }

        public Visitor(int visitor_id, string visitor_name, double discount)
        {
                Visitor_id = visitor_id;
            Visitor_name = visitor_name;
            Discount = discount;
        }
    }
}
