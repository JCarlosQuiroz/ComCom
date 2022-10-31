using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class montos
    {
        public uint id { get; set; }
        public decimal cantidad { get; set; }
        public DateTime created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public int status { get; set; }
    }
}
