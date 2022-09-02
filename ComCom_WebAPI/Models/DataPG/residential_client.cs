using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class residential_client
    {
        public residential_client()
        {
            reference_person = new HashSet<reference_person>();
        }

        public int client_ptr_id { get; set; }
        public string? proof_address_file { get; set; }
        public string barcode { get; set; } = null!;

        public virtual client client_ptr { get; set; } = null!;
        public virtual ICollection<reference_person> reference_person { get; set; }
    }
}
