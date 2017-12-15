using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Security_Logins")]
    public class SecurityLoginsPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Login { get; set; }
        [Column("Source_Ip")]
        public String Password { get; set; }
        public String Salt { get; set; }
        [Column("Created_Date")]

        public DateTime CreatedDate { get; set; }
        [Column("Password_Update_Dated")]

        public DateTime PasswordUpdateDated { get; set; }
        [Column("Agreement_Accepted")]

        public DateTime AgreementAccepted { get; set; }
        [Column("Is_Locked")]

        public Boolean IsLocked { get; set; }
        [Column("Is_Inactive")]

        public Boolean IsInactive { get; set; }
        [Column("Email_Address")]

        public string EmailAddress { get; set; }
        [Column("Phone_Number")]

        public string PhoneNumber { get; set; }
        [Column("Full_Name")]

        public String FullName { get; set; }
        [Column("Force_Change_Password")]

        public Boolean ForceChangePassword { get; set; }
        [Column("Preferred_Language")]

        public String PreferredLanguage { get; set; }
        [Column("Time_Stamp")]
        public Byte? TimeStamp { get; set; }
        [Column("Source_Ip")]
        public String SourceIp { get; set; }
        [Column("Logon_Date")]
        public DateTime LogonDate { get; set; }
        [Column("IsSucessful")]
        public Boolean IsSuccessful { get; set; }
        
    }
}
