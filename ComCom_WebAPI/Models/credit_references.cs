using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_references
    {
        public int id_reference { get; set; }
        public int? id_person { get; set; }
        public string? fullname { get; set; }
        public string? relationship { get; set; }
        public string? phone { get; set; }
    }
}
