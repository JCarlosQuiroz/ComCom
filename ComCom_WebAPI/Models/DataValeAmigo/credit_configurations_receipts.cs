using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_configurations_receipts
    {
        public credit_configurations_receipts()
        {
            credit_configurations_receipts_fields = new HashSet<credit_configurations_receipts_fields>();
        }

        public uint id_configuration_receipt { get; set; }
        public uint id_user { get; set; }
        public byte status { get; set; }
        public byte columns { get; set; }
        public byte rows { get; set; }
        public decimal column_space { get; set; }
        public decimal row_space { get; set; }
        public string layout { get; set; } = null!;
        public DateTime register_date { get; set; }

        public virtual core_users id_userNavigation { get; set; } = null!;
        public virtual ICollection<credit_configurations_receipts_fields> credit_configurations_receipts_fields { get; set; }
    }
}
