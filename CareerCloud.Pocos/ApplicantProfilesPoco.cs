using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Profiles")]
    public class ApplicantProfilesPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Login { get; set; }
        [Column("Current_Salary")]
        public Decimal CurrentSalary { get; set; }
        [Column("Current_Rate")]
        public Decimal CurrentRate { get; set; }
        public String Currency { get; set; }
        [Column("Country_Code")]
        public String CountryCode { get; set; }
        [Column("State_Province_Code")]
        public String StateProvinceCode { get; set; }
        [Column("Street_Address")]
        public String StreetAddress { get; set; }
        [Column("City_Town")]
        public String CityTown { get; set; }
        [Column("Zip_Postal")]
        public String ZipPostal { get; set; }
        [Column("Time_Stamp")]
        public Byte[] TimeStamp { get; set; }







    }
}
