using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_employments
    {
        public collection_employments()
        {
            collection_managers = new HashSet<collection_managers>();
        }

        public uint id_employment { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;

        public virtual ICollection<collection_managers> collection_managers { get; set; }
    }
}
