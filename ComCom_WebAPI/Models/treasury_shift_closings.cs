using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class treasury_shift_closings
    {
        public treasury_shift_closings()
        {
            id_box_closure = new HashSet<treasury_box_closures>();
        }

        public uint id_shift_closing { get; set; }
        public uint id_user { get; set; }
        public uint id_box { get; set; }
        public decimal in_amount { get; set; }
        public decimal out_amount { get; set; }
        public decimal available { get; set; }
        public decimal taked { get; set; }
        public DateTime date { get; set; }
        public string? note { get; set; }
        public int? id_user_cancellation { get; set; }
        public string? cancellation_note { get; set; }
        public DateTime? cancellation_date { get; set; }
        public int? id_shift_closing_type { get; set; }

        public virtual treasury_boxes id_boxNavigation { get; set; } = null!;
        public virtual treasury_shift_closing_types? id_shift_closing_typeNavigation { get; set; }
        public virtual core_users id_userNavigation { get; set; } = null!;

        public virtual ICollection<treasury_box_closures> id_box_closure { get; set; }
    }
}
