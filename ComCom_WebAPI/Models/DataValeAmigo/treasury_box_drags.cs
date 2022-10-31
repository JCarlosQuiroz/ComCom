using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class treasury_box_drags
    {
        public uint id_drag { get; set; }
        public uint id_box_closure { get; set; }
        public uint id_box { get; set; }
        public DateOnly date { get; set; }
        public DateOnly apply_date { get; set; }
        public decimal amount { get; set; }

        public virtual treasury_boxes id_boxNavigation { get; set; } = null!;
        public virtual treasury_box_closures id_box_closureNavigation { get; set; } = null!;
    }
}
