using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class SystemCountryCodesPoco
    {
        [Key]
        public String Code { get; set; }
        public String Name { get; set; }
    }
}
