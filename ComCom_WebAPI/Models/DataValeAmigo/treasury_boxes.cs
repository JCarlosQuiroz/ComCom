using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class treasury_boxes
    {
        public treasury_boxes()
        {
            collection_receipts = new HashSet<collection_receipts>();
            treasury_box_closures = new HashSet<treasury_box_closures>();
            treasury_box_drags = new HashSet<treasury_box_drags>();
            treasury_boxes_injections = new HashSet<treasury_boxes_injections>();
            treasury_boxes_payments = new HashSet<treasury_boxes_payments>();
            treasury_providers_requests = new HashSet<treasury_providers_requests>();
            treasury_shift_closings = new HashSet<treasury_shift_closings>();
            id_user1 = new HashSet<core_users>();
        }

        public uint id_box { get; set; }
        public uint id_branch { get; set; }
        public uint id_user { get; set; }
        public byte status { get; set; }
        public byte type { get; set; }
        public TimeOnly start { get; set; }
        public TimeOnly end { get; set; }
        public decimal limit { get; set; }
        public string name { get; set; } = null!;
        public byte order { get; set; }

        public virtual core_branches id_branchNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
        public virtual ICollection<collection_receipts> collection_receipts { get; set; }
        public virtual ICollection<treasury_box_closures> treasury_box_closures { get; set; }
        public virtual ICollection<treasury_box_drags> treasury_box_drags { get; set; }
        public virtual ICollection<treasury_boxes_injections> treasury_boxes_injections { get; set; }
        public virtual ICollection<treasury_boxes_payments> treasury_boxes_payments { get; set; }
        public virtual ICollection<treasury_providers_requests> treasury_providers_requests { get; set; }
        public virtual ICollection<treasury_shift_closings> treasury_shift_closings { get; set; }

        public virtual ICollection<core_users> id_user1 { get; set; }
    }
}
