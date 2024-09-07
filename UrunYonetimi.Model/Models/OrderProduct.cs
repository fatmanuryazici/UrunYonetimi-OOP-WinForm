using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunYonetimi.Model.Models
{
    public class OrderProduct : BaseModel
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public double SubTotalPrice { get; set; }
        public int Piece { get; set; }
    }
}
