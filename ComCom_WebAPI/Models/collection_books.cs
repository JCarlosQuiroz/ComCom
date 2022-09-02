using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_books
    {
        public uint id_book { get; set; }
        public uint id_type { get; set; }
        public uint? id_branch { get; set; }
        public byte status { get; set; }
        public uint initial_folio { get; set; }
        public uint final_folio { get; set; }
        public uint quantity { get; set; }
        public DateTime timestamp { get; set; }
        public DateOnly? shipping_date { get; set; }
        public DateOnly? cancel_date { get; set; }

        public virtual core_branches? id_branchNavigation { get; set; }
        public virtual collection_types id_typeNavigation { get; set; } = null!;
    }
}
