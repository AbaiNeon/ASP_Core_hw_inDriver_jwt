using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP_hw_inDriver_jwt.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Login { get; set; }

        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
