using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_protections_requests_files_types
    {
        public credit_protections_requests_files_types()
        {
            credit_protections_requests_files = new HashSet<credit_protections_requests_files>();
            id_protection_request_type = new HashSet<credit_protections_requests_types>();
        }

        public uint id_protection_request_file_type { get; set; }
        public string name { get; set; } = null!;
        public byte required { get; set; }
        public byte status { get; set; }

        public virtual ICollection<credit_protections_requests_files> credit_protections_requests_files { get; set; }

        public virtual ICollection<credit_protections_requests_types> id_protection_request_type { get; set; }
    }
}
