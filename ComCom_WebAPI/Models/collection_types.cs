using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_types
    {
        public collection_types()
        {
            collection_assignments = new HashSet<collection_assignments>();
            collection_books = new HashSet<collection_books>();
            collection_coordinations = new HashSet<collection_coordinations>();
            collection_groups = new HashSet<collection_groups>();
        }

        public uint id_type { get; set; }
        public byte status { get; set; }
        public byte can_punish { get; set; }
        public string name { get; set; } = null!;
        public uint start_due_days { get; set; }
        public uint end_due_days { get; set; }

        public virtual ICollection<collection_assignments> collection_assignments { get; set; }
        public virtual ICollection<collection_books> collection_books { get; set; }
        public virtual ICollection<collection_coordinations> collection_coordinations { get; set; }
        public virtual ICollection<collection_groups> collection_groups { get; set; }
    }
}
