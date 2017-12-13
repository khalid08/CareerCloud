using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class CompanyJobEducationsPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Job { get; set; }
        public String Major { get; set; }
        public Int32 Importance { get; set; }
        public Byte[] TimeStamp { get; set; }
    }
}
