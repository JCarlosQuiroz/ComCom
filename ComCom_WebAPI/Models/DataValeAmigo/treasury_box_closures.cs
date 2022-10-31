using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class treasury_box_closures
    {
        public treasury_box_closures()
        {
            treasury_box_drags = new HashSet<treasury_box_drags>();
            id_box_injection = new HashSet<treasury_boxes_injections>();
            id_box_payment = new HashSet<treasury_boxes_payments>();
            id_shift_closing = new HashSet<treasury_shift_closings>();
        }

        public uint id_box_closure { get; set; }
        public uint id_user { get; set; }
        public uint id_box { get; set; }
        public byte status { get; set; }
        public DateOnly date { get; set; }
        public decimal in_amount { get; set; }
        public decimal out_amount { get; set; }
        public decimal available { get; set; }
        public DateTime register_date { get; set; }
        public byte drag_available { get; set; }

        public virtual treasury_boxes id_boxNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
        public virtual ICollection<treasury_box_drags> treasury_box_drags { get; set; }

        public virtual ICollection<treasury_boxes_injections> id_box_injection { get; set; }
        public virtual ICollection<treasury_boxes_payments> id_box_payment { get; set; }
        public virtual ICollection<treasury_shift_closings> id_shift_closing { get; set; }
    }
}
