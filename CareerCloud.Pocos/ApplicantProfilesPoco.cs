using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
     public class ApplicantProfilesPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Login { get; set; }
        public Decimal CurrentSalary { get; set; }
        public Decimal CurrentRate { get; set; }
        public String Currency { get; set; }
        public String CountryCode { get; set; }
        public String StateProvinceCode { get; set; }
        public String StreetAddress { get; set; }

        public String CityTown { get; set; }
        public String ZipPostal { get; set; }
        public Byte[] TimeStamp { get; set; }







    }
}
