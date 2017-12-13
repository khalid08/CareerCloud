using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class CompanyProfilesPoco
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime RegistrationDate { get; set; }
        public String CompanyWebsite { get; set; }
        public String ContactPhone { get; set; }
        public String ContactName { get; set; }
        public Byte[] CompanyLogo { get; set; }
        public Byte[] TimeStamp { get; set; }
       


    }
}
