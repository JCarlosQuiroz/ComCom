using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class treasury_providers_requests
    {
        public uint id_provider_request { get; set; }
        public uint id_provider { get; set; }
        public uint? id_request { get; set; }
        public uint? id_box { get; set; }
        public uint? id_user { get; set; }
        public byte status { get; set; }
        public byte type { get; set; }
        public DateTime datetime { get; set; }
        public decimal amount { get; set; }
        public int? id_user_cancellation { get; set; }
        public string? cancellation_note { get; set; }
        public DateTime? cancellation_date { get; set; }

        public virtual treasury_boxes? id_boxNavigation { get; set; }
        public virtual treasury_providers id_providerNavigation { get; set; } = null!;
        public virtual treasury_requests? id_requestNavigation { get; set; }
        public virtual core_users? id_userNavigation { get; set; }
    }
}
