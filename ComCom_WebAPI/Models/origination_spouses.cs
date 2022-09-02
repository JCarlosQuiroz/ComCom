using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_spouses
    {
        public origination_spouses()
        {
            origination_persons = new HashSet<origination_persons>();
        }

        public uint id_spouse { get; set; }
        public uint id_person { get; set; }
        public uint id_application { get; set; }
        public uint id_relationship { get; set; }
        public byte status { get; set; }
        public DateTime timestamp { get; set; }

        public virtual origination_applications id_applicationNavigation { get; set; } = null!;
        public virtual origination_persons id_personNavigation { get; set; } = null!;
        public virtual origination_relationships id_relationshipNavigation { get; set; } = null!;
        public virtual ICollection<origination_persons> origination_persons { get; set; }
    }
}
