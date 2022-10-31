using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class piorpi_black_lists
    {
        public piorpi_black_lists()
        {
            piorpi_black_lists_entries = new HashSet<piorpi_black_lists_entries>();
        }

        public uint id_black_list { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;
        public DateTime? last_update { get; set; }
        public string? service { get; set; }

        public virtual ICollection<piorpi_black_lists_entries> piorpi_black_lists_entries { get; set; }
    }
}
