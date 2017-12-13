using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("System_Language_Codes")]
    public class SystemLanguageCodesPoco
    {
        
        [Key]
        [Column("Language_Id")]
        public String LanguageId { get; set; }
        public String Name { get; set; }
        [Column("Native_Name")]

        public String NativeName { get; set; }
    }
}
