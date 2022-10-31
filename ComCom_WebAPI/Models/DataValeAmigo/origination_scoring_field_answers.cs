using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_scoring_field_answers
    {
        public uint id_scoring_field_answer { get; set; }
        public uint id_scoring_field { get; set; }
        public uint id_user { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;
        public uint value { get; set; }

        public virtual origination_scoring_fields id_scoring_fieldNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
    }
}
