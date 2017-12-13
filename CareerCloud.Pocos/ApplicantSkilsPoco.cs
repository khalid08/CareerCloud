using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class ApplicantSkilsPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Applicant { get; set; }
        public String Skill { get; set; }
        public String SkillLevel { get; set; }
        public Byte StartMonth { get; set; }
        public Int32 StartYear { get; set; }
        public Byte EndMonth { get; set; }
        public Int32 EndYear { get; set; }
        public Byte[] TimeStamp { get; set; }
       
    }
}
