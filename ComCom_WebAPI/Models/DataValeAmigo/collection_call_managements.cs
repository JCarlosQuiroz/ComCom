using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_call_managements
    {
        public uint id_call_management { get; set; }
        public uint id_call_type { get; set; }
        public uint id_user { get; set; }
        public uint id_distributor { get; set; }
        public uint id_branch { get; set; }
        public uint id_coordination { get; set; }
        public uint? id_phone { get; set; }
        public byte? call_result { get; set; }
        public DateTime call_date_start { get; set; }
        public DateTime? call_date_end { get; set; }
        public byte? apply_pp { get; set; }
        public byte? accept_pp { get; set; }
        public uint? id_amount { get; set; }
        public byte? incidence { get; set; }
        public byte? service { get; set; }
        public byte? protection { get; set; }
    }
}
