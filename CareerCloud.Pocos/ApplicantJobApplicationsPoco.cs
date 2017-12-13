using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class ApplicantJobApplicationsPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Applicant { get; set; }
        public Guid Job { get; set; }
        public DateTime DateTime { get; set; }
        public Byte[] TimeStamp { get; set; }
    }
}
