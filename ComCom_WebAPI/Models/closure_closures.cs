using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class closure_closures
    {
        public closure_closures()
        {
            closure_closures_entries = new HashSet<closure_closures_entries>();
        }

        public uint id_closure { get; set; }
        public uint? id_user { get; set; }
        public byte status { get; set; }
        public DateOnly date { get; set; }
        public uint credits { get; set; }
        public byte percentage { get; set; }
        public decimal due_balance { get; set; }
        public decimal payable_balance { get; set; }
        public decimal current_balance { get; set; }
        public decimal total_balance { get; set; }

        public virtual core_users? id_userNavigation { get; set; }
        public virtual ICollection<closure_closures_entries> closure_closures_entries { get; set; }
    }
}
