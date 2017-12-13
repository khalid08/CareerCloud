using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class CompanyLocationsPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Company { get; set; }
        public String CountryCode { get; set; }
        public String StateProvinceCode { get; set; }
        public String StreetAddress { get; set; }
        public String CityTown { get; set; }
        public String ZipPostalCode { get; set; }
        public Byte[] TimeStamp { get; set; }

    }
}
