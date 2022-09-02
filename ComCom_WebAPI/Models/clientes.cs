using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class clientes
    {
        public uint id { get; set; }
        public string nombre { get; set; } = null!;
        public string apellido_paterno { get; set; } = null!;
        public string apellido_materno { get; set; } = null!;
        public DateTime created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public int status { get; set; }
    }
}
