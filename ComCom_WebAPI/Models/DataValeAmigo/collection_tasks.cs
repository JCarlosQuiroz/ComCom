using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_tasks
    {
        public uint id_task { get; set; }
        public uint id_manager { get; set; }
        public uint id_distributor { get; set; }
        public string description { get; set; } = null!;
        public DateTime timestamp { get; set; }
        public DateTime schedule { get; set; }

        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
        public virtual collection_managers id_managerNavigation { get; set; } = null!;
    }
}
