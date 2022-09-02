using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_distributors_thrift_configuration
    {
        public uint id_thrift_configuration { get; set; }
        public int? id_distributor { get; set; }
        public uint id_credit { get; set; }
        public int id_thrift_percentage { get; set; }
        public DateOnly? date { get; set; }
        public sbyte? status { get; set; }

        public virtual credit_credits id_creditNavigation { get; set; } = null!;
    }
}
