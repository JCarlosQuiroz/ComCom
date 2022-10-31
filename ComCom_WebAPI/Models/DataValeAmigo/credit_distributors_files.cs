using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_distributors_files
    {
        public uint id_distributor_file { get; set; }
        public uint id_distributor { get; set; }
        public uint id_file_type { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;
        public string mimetype { get; set; } = null!;
        public uint size { get; set; }
        public DateTime uploaded { get; set; }
        public string filename { get; set; } = null!;
        public uint id_person { get; set; }

        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
        public virtual origination_files_types id_file_typeNavigation { get; set; } = null!;
        public virtual credit_persons id_personNavigation { get; set; } = null!;
    }
}
