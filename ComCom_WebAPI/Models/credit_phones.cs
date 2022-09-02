using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_phones
    {
        public uint id_phone { get; set; }
        public uint id_phone_type { get; set; }
        public uint id_person { get; set; }
        public byte status { get; set; }
        public string number { get; set; } = null!;

        public virtual credit_persons id_personNavigation { get; set; } = null!;
        public virtual origination_phones_types id_phone_typeNavigation { get; set; } = null!;
    }
}
