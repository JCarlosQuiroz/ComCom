using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_spouses
    {
        public uint id_spouse { get; set; }
        public uint id_person { get; set; }
        public uint id_distributor { get; set; }
        public uint id_relationship { get; set; }
        public byte status { get; set; }
        public DateTime timestamp { get; set; }

        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
        public virtual credit_persons id_personNavigation { get; set; } = null!;
        public virtual origination_relationships id_relationshipNavigation { get; set; } = null!;
    }
}
