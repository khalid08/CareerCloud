using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class ApplicantEducationsPoco
    {
        [Table("Applicant_Educations")]
        [Key]
        public Guid Id { get; set; }
        public Guid Applicant { get; set; }
        public String Major { get; set; }
        public String CertificateDiploma { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public Byte CompletionPercent { get; set; }
        public Byte[] TimeStamp { get; set; }
    }
}
