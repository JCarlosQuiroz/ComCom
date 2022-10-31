using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_group_zipcodes
    {
        public uint id_group_zipcode { get; set; }
        public uint id_group { get; set; }
        public string zipcode { get; set; } = null!;
        public string neighborhood { get; set; } = null!;

        public virtual collection_groups id_groupNavigation { get; set; } = null!;
    }
}
