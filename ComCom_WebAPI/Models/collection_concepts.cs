using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_concepts
    {
        public int id_concept { get; set; }
        public string? description { get; set; }
        public sbyte? status { get; set; }
    }
}
