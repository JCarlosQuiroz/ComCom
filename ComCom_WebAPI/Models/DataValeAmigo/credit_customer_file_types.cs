using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_customer_file_types
    {
        public credit_customer_file_types()
        {
            credit_customers_files = new HashSet<credit_customers_files>();
        }

        public uint id_customer_file_type { get; set; }
        public byte status { get; set; }
        public byte required { get; set; }
        public string name { get; set; } = null!;

        public virtual ICollection<credit_customers_files> credit_customers_files { get; set; }
    }
}
