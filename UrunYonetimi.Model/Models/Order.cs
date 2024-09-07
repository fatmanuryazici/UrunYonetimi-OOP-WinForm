using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunYonetimi.Model.Models
{
    public class Order : BaseModel
    {
        public Guid No { get; set; }
        public string Description { get; set; }
        public double TotalPrice { get; set; }
        public Guid CustomerId { get; set; }
    }
}
