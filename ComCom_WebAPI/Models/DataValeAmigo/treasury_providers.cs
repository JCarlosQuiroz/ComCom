using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class treasury_providers
    {
        public treasury_providers()
        {
            treasury_boxes_injections = new HashSet<treasury_boxes_injections>();
            treasury_boxes_payments = new HashSet<treasury_boxes_payments>();
            treasury_providers_requests = new HashSet<treasury_providers_requests>();
            treasury_requests = new HashSet<treasury_requests>();
        }

        public uint id_provider { get; set; }
        public uint id_branch { get; set; }
        public byte status { get; set; }
        public decimal minimum { get; set; }
        public decimal maximun { get; set; }
        public string name { get; set; } = null!;

        public virtual core_branches id_branchNavigation { get; set; } = null!;
        public virtual ICollection<treasury_boxes_injections> treasury_boxes_injections { get; set; }
        public virtual ICollection<treasury_boxes_payments> treasury_boxes_payments { get; set; }
        public virtual ICollection<treasury_providers_requests> treasury_providers_requests { get; set; }
        public virtual ICollection<treasury_requests> treasury_requests { get; set; }
    }
}
