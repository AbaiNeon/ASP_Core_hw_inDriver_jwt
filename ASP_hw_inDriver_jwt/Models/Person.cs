using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_hw_inDriver_jwt.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsClient { get; set; }
        public bool IsDriver { get; set; }

        
    }
}
