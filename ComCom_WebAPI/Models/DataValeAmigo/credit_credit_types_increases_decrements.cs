using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_credit_types_increases_decrements
    {
        public uint id_credit_type_increment_decrement { get; set; }
        public uint id_credit_type { get; set; }
        public byte type { get; set; }
        public byte? months_old { get; set; }
        public decimal discount { get; set; }
        public byte periods { get; set; }
        public decimal? available { get; set; }
        public decimal amount { get; set; }
    }
}
