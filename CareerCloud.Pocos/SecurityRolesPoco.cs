using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class SecurityRolesPoco
    {
        [Key]
        public Guid Id { get; set; }
        public String Role { get; set; }
        public Boolean IsInactive { get; set; }
    }
}
