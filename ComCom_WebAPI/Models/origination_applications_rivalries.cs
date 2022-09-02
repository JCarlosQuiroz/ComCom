using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_applications_rivalries
    {
        public uint id_application_rivalry { get; set; }
        public uint id_application { get; set; }
        public uint id_rivalry { get; set; }
        public byte antiquity { get; set; }
        public decimal sold { get; set; }
        public decimal credit_line { get; set; }

        public virtual origination_applications id_applicationNavigation { get; set; } = null!;
        public virtual origination_rivalries id_rivalryNavigation { get; set; } = null!;
    }
}
