using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class CompanyJobDescriptionsPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Job { get; set; }
        public String JobName { get; set; }

        public String JobDescriptions { get; set; }

        public Byte[] TimeStamp { get; set; }
    }
}
