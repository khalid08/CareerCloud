using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
   public class SecurityLoginsPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Login { get; set; }
        public String SourceIp { get; set; }
        public DateTime LogonDate { get; set; }
        public Boolean IsSuccessful { get; set; }
        
    }
}
