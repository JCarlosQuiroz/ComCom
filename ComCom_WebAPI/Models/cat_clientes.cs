using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class cat_clientes
    {
        public int id { get; set; }
        public string? nombre { get; set; }
        public string? edad { get; set; }
        public string? telefono { get; set; }
        public int? status { get; set; }
    }
}
