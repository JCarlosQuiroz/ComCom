using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class piorpi_black_lists_entries
    {
        public uint id_black_list_entry { get; set; }
        public uint id_black_list { get; set; }
        public string? name { get; set; }
        public string? middle_name { get; set; }
        public string? last_name { get; set; }
        public string? second_last_name { get; set; }
        public string? place_birth { get; set; }
        public string? address { get; set; }
        public string? name_soundex { get; set; }
        public string? last_name_soundex { get; set; }
        public string? reference { get; set; }
        public string? list_type { get; set; }
        public string? note { get; set; }

        public virtual piorpi_black_lists id_black_listNavigation { get; set; } = null!;
    }
}
