using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_distributors_thrift
    {
        public uint id_thrift { get; set; }
        public int? id_distributor { get; set; }
        public int? id_credit { get; set; }
        public int? id_thrift_configuration { get; set; }
        public decimal? amount { get; set; }
        public DateOnly? date { get; set; }
        public DateTime? datetime { get; set; }
        public sbyte? status { get; set; }
    }
}
