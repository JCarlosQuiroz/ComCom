using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_customers_files
    {
        public uint id_customer_file { get; set; }
        public uint id_customer { get; set; }
        public uint id_customer_file_type { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;
        public string mimetype { get; set; } = null!;
        public uint size { get; set; }
        public DateTime uploaded { get; set; }
        public string filename { get; set; } = null!;

        public virtual credit_customers id_customerNavigation { get; set; } = null!;
        public virtual credit_customer_file_types id_customer_file_typeNavigation { get; set; } = null!;
    }
}
