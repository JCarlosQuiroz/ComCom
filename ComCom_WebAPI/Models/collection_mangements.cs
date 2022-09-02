using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_mangements
    {
        public uint id_management { get; set; }
        public uint id_manager { get; set; }
        public uint id_result { get; set; }
        public decimal? amount { get; set; }
        public string? description { get; set; }
        public DateOnly? date { get; set; }
        public DateTime timestamp { get; set; }

        public virtual collection_managers id_managerNavigation { get; set; } = null!;
        public virtual collection_results id_resultNavigation { get; set; } = null!;
    }
}
