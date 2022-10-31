using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_result_types
    {
        public collection_result_types()
        {
            collection_managements = new HashSet<collection_managements>();
        }

        public uint id_result_type { get; set; }
        public byte status { get; set; }
        public byte type { get; set; }
        public byte result { get; set; }
        public string name { get; set; } = null!;
        public byte has_date { get; set; }
        public byte has_amount { get; set; }
        public string? amount_label { get; set; }
        public string? date_label { get; set; }
        public byte require_receipt { get; set; }

        public virtual ICollection<collection_managements> collection_managements { get; set; }
    }
}
