using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_validations_files
    {
        public uint id_validation_file { get; set; }
        public uint id_validation { get; set; }
        public uint id_file_type { get; set; }
        public byte status { get; set; }

        public virtual origination_files_types id_file_typeNavigation { get; set; } = null!;
        public virtual origination_validations id_validationNavigation { get; set; } = null!;
    }
}
