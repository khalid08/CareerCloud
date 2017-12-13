using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class SecurityLoginsRolesPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Login { get; set; }
        public Guid Role { get; set; }
        public Byte[] TimeStamp { get; set; }
    }
}
