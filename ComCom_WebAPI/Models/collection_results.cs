using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_results
    {
        public collection_results()
        {
            collection_mangements = new HashSet<collection_mangements>();
        }

        public uint id_result { get; set; }
        public byte status { get; set; }
        public byte clasification { get; set; }
        public sbyte? has_date { get; set; }
        public sbyte? has_amount { get; set; }
        public string description { get; set; } = null!;
        public string? amount_label { get; set; }
        public string? date_label { get; set; }
        public DateTime timestamp { get; set; }

        public virtual ICollection<collection_mangements> collection_mangements { get; set; }
    }
}
