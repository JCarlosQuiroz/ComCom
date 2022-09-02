using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_thrift_percentages
    {
        public int id_thrift_percentage { get; set; }
        public string? name { get; set; }
        public double percentage { get; set; }
        public double? annual_percent { get; set; }
        public sbyte status { get; set; }
    }
}
