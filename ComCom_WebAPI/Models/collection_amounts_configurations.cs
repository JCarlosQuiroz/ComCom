using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_amounts_configurations
    {
        public uint id_amount_configuration { get; set; }
        public decimal max_amount { get; set; }
        public decimal alert_percentage { get; set; }
        public byte? status { get; set; }
    }
}
