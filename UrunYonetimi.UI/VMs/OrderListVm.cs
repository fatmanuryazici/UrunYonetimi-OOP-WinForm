using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunYonetimi.UI.VMs
{
    public class OrderListVm
    {
        public Guid Id { get; set; }
        public Guid No { get; set; }
        public string Description { get; set; }
        public string TotalPrice { get; set; }
        public Guid CustomerId { get; set; }
        public string CustomerName{ get; set; }        
    }
}
