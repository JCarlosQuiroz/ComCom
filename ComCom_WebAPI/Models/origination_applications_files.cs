using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_applications_files
    {
        public uint id_application_file { get; set; }
        public uint id_application { get; set; }
        public uint id_file_type { get; set; }
        public byte status { get; set; }
        public string? comment { get; set; }
        public string name { get; set; } = null!;
        public string mimetype { get; set; } = null!;
        public uint size { get; set; }
        public DateTime uploaded { get; set; }
        public string filename { get; set; } = null!;
        public uint id_person { get; set; }

        public virtual origination_applications id_applicationNavigation { get; set; } = null!;
        public virtual origination_files_types id_file_typeNavigation { get; set; } = null!;
        public virtual origination_persons id_personNavigation { get; set; } = null!;
    }
}
