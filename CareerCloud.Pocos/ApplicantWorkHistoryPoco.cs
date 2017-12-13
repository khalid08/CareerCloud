using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
   public class ApplicantWorkHistoryPoco
    {
        [Key]

        public Guid Id { get; set; }
        public Guid Applicant { get; set; }
        public String CompanyName { get; set; }
        public String CountryCode { get; set; }
        public String Location { get; set; }
        public String JobTitle { get; set; }
        public String JobDescription { get; set; }
        public Byte StartMonth { get; set; }
        public Int32 StartYear { get; set; }
        public Byte EndMonth { get; set; }
        public Int32 EndYear { get; set; }
        public Byte[] TimeStamp { get; set; }

    }
}
