﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public class SystemLanguageCodesPoco
    {
        [Key]
        public String LanguageId { get; set; }
        public String Name { get; set; }
        public String NativeName { get; set; }
    }
}
