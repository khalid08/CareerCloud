using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class CompanyJobsPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Company { get; set; }
        public DateTime ProfileCreated { get; set; }
        public Boolean IsInactive { get; set; }
        public Boolean IsCompanyHidden { get; set; }
        public Byte[] TImeStamp { get; set; }
    }
}
