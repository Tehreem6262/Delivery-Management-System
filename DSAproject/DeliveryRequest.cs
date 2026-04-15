using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAproject
{
    using System.Collections.Generic;

    public class DeliveryRequest
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int? RiderId { get; set; } 
        public string PickupAddress { get; set; }
        public string DropoffAddress { get; set; }
        public string Status { get; set; } 
        public int Distance { get; set; } 
        public List<int> OptimizedRoute { get; set; } 
    }

}
