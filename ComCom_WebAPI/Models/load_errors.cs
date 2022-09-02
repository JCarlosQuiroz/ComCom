using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class load_errors
    {
        public uint id_error { get; set; }
        public sbyte? section { get; set; }
        public string? id { get; set; }
        public string? value { get; set; }
        public int? line { get; set; }
        public string? message { get; set; }
    }
}
