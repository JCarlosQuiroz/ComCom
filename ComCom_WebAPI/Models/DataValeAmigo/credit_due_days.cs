using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_due_days
    {
        public uint id_due_day { get; set; }
        public byte status { get; set; }
        public uint of { get; set; }
        public uint up { get; set; }
        public string name { get; set; } = null!;
    }
}
