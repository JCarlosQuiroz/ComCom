using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_requests_files
    {
        public uint id_request_file { get; set; }
        public uint id_request { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;
        public string mimetype { get; set; } = null!;
        public uint size { get; set; }
        public DateTime uploaded { get; set; }
        public string filename { get; set; } = null!;

        public virtual credit_requests id_requestNavigation { get; set; } = null!;
    }
}
