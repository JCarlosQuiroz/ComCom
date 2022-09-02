using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_protections_requests_files
    {
        public uint id_protection_request_file { get; set; }
        public uint id_protection_request { get; set; }
        public uint id_protection_request_file_type { get; set; }
        public byte status { get; set; }
        public string? comment { get; set; }
        public string name { get; set; } = null!;
        public string mimetype { get; set; } = null!;
        public uint size { get; set; }
        public DateTime uploaded { get; set; }
        public string filename { get; set; } = null!;

        public virtual credit_protections_requests id_protection_requestNavigation { get; set; } = null!;
        public virtual credit_protections_requests_files_types id_protection_request_file_typeNavigation { get; set; } = null!;
    }
}
