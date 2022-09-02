using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_activations
    {
        public uint id_activations { get; set; }
        public DateOnly date_authorization { get; set; }
        public DateOnly date_activation { get; set; }
        public DateTime datetime { get; set; }
        public uint id_distributor { get; set; }
        public uint id_promoter { get; set; }
        public uint branch { get; set; }
        public uint coordination { get; set; }
        public decimal? amount { get; set; }
        public uint guarantee { get; set; }
        public string level { get; set; } = null!;
        public uint id_user { get; set; }
    }
}
