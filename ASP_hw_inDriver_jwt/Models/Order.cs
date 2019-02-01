using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_hw_inDriver_jwt.Models
{
    public class Order
    {
        public int Id { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public User Client { get; set; }
        
        public string PointA { get; set; }
        public string PointB { get; set; }
        public DateTime OrderReceiptTime { get; set; } = DateTime.Now;
        public int Price { get; set; }

        public bool ExecutionStatus { get; set; }

        
    }

    
}
