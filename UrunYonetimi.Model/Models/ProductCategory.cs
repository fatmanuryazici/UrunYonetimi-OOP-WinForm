using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunYonetimi.Model.Models
{
    public class ProductCategory : BaseModel
    {
        public Guid ProductId { get; set; }
        public Guid CategoryId { get; set; }
    }
}
