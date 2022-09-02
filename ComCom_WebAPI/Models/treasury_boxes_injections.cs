using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class treasury_boxes_injections
    {
        public treasury_boxes_injections()
        {
            id_box_closure = new HashSet<treasury_box_closures>();
        }

        public uint id_box_injection { get; set; }
        public uint id_box { get; set; }
        public uint id_provider { get; set; }
        public uint? id_user { get; set; }
        public byte status { get; set; }
        public DateTime datetime { get; set; }
        public decimal amount { get; set; }
        public int? id_provider_request { get; set; }

        public virtual treasury_boxes id_boxNavigation { get; set; } = null!;
        public virtual treasury_providers id_providerNavigation { get; set; } = null!;
        public virtual core_users? id_userNavigation { get; set; }

        public virtual ICollection<treasury_box_closures> id_box_closure { get; set; }
    }
}
