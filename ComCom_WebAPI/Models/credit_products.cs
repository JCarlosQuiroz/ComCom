using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_products
    {
        public uint id_product { get; set; }
        public uint? id_payment { get; set; }
        public uint id_box { get; set; }
        public uint id_product_type { get; set; }
        public uint id_product_brand { get; set; }
        public string model { get; set; } = null!;
        public byte status { get; set; }
        public DateTime timestamp { get; set; }
        public DateTime? delivery_date { get; set; }
        public uint id_user { get; set; }
        public byte? type { get; set; }
        public uint? id_collaborator { get; set; }
        public string? name { get; set; }
        public string? job_name { get; set; }
        public float? amount { get; set; }
        public int? id_distributor { get; set; }
    }
}
