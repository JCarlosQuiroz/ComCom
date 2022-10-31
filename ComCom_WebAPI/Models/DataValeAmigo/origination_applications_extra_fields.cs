using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_applications_extra_fields
    {
        public uint id_application_extra_field { get; set; }
        public uint id_application { get; set; }
        public uint id_extra_field { get; set; }
        public uint id_person { get; set; }
        public string value { get; set; } = null!;
        public byte entity { get; set; }

        public virtual origination_applications id_applicationNavigation { get; set; } = null!;
        public virtual origination_extra_fields id_extra_fieldNavigation { get; set; } = null!;
        public virtual origination_persons id_personNavigation { get; set; } = null!;
    }
}
