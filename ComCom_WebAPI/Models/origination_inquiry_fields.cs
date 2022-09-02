using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_inquiry_fields
    {
        public uint id_inquiry_field { get; set; }
        public uint id_inquiry { get; set; }
        public byte status { get; set; }
        public byte type { get; set; }
        public sbyte required { get; set; }
        public string name { get; set; } = null!;
        public string? values { get; set; }

        public virtual origination_inquiries id_inquiryNavigation { get; set; } = null!;
    }
}
