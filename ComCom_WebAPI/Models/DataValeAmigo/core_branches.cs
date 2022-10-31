using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class core_branches
    {
        public core_branches()
        {
            closure_closures_entries = new HashSet<closure_closures_entries>();
            collection_books = new HashSet<collection_books>();
            collection_coordinations = new HashSet<collection_coordinations>();
            collection_groups = new HashSet<collection_groups>();
            collection_receipt_books = new HashSet<collection_receipt_books>();
            collection_receipt_requests = new HashSet<collection_receipt_requests>();
            core_stores = new HashSet<core_stores>();
            credit_customers = new HashSet<credit_customers>();
            credit_distributors = new HashSet<credit_distributors>();
            credit_puchases = new HashSet<credit_puchases>();
            origination_applications = new HashSet<origination_applications>();
            treasury_boxes = new HashSet<treasury_boxes>();
            treasury_providers = new HashSet<treasury_providers>();
            id_user = new HashSet<core_users>();
        }

        public uint id_branch { get; set; }
        public uint id_zone { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;
        public uint zipcode { get; set; }
        public uint id_configuration_interest { get; set; }
        public sbyte? has_thrift { get; set; }
        public int? id_configuration_multiple_coupon { get; set; }
        public int? id_configuration_charge_type { get; set; }
        public int? id_configuration_discount { get; set; }
        public string? alias { get; set; }
        public bool? is_curp_active { get; set; }
        public int? id_management { get; set; }
        public int? id_configuration_thrift_day { get; set; }

        public virtual credit_configurations_interests id_configuration_interestNavigation { get; set; } = null!;
        public virtual core_zones id_zoneNavigation { get; set; } = null!;
        public virtual ICollection<closure_closures_entries> closure_closures_entries { get; set; }
        public virtual ICollection<collection_books> collection_books { get; set; }
        public virtual ICollection<collection_coordinations> collection_coordinations { get; set; }
        public virtual ICollection<collection_groups> collection_groups { get; set; }
        public virtual ICollection<collection_receipt_books> collection_receipt_books { get; set; }
        public virtual ICollection<collection_receipt_requests> collection_receipt_requests { get; set; }
        public virtual ICollection<core_stores> core_stores { get; set; }
        public virtual ICollection<credit_customers> credit_customers { get; set; }
        public virtual ICollection<credit_distributors> credit_distributors { get; set; }
        public virtual ICollection<credit_puchases> credit_puchases { get; set; }
        public virtual ICollection<origination_applications> origination_applications { get; set; }
        public virtual ICollection<treasury_boxes> treasury_boxes { get; set; }
        public virtual ICollection<treasury_providers> treasury_providers { get; set; }

        public virtual ICollection<core_users> id_user { get; set; }
    }
}
