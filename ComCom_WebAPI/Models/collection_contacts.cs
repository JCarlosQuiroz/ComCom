using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_contacts
    {
        public int id_contact { get; set; }
        public string? description { get; set; }
        public sbyte? status { get; set; }
    }
}
