using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    class CompanyDescriptionsPoco
    {
        [Key]

        public Guid Id { get; set; }
        public Guid Company { get; set; }
        public String Language { get; set; }
        public String CompanyName { get; set; }
        public String CompanyDescription { get; set; }
        public Byte[] TimeStamp { get; set; }
    }
}
