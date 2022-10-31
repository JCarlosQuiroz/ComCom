using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_personal_references
    {
        public uint id_personal_reference { get; set; }
        public uint id_distributor { get; set; }
        public uint id_relationship { get; set; }
        public uint id_person { get; set; }
        public uint? time { get; set; }

        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
        public virtual credit_persons id_personNavigation { get; set; } = null!;
        public virtual origination_relationships id_relationshipNavigation { get; set; } = null!;
    }
}
