using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class core_persons_curp_validations_
    {
        public double? id { get; set; }
        public string? primer_nombre { get; set; }
        public string? segundo_nombre { get; set; }
        public string? apellido_paterno { get; set; }
        public string? apellido_materno { get; set; }
        public string? curp { get; set; }
        public DateTime? fechaIngreso { get; set; }
        public string? sucursal { get; set; }
        public string? departamento { get; set; }
        public string? puesto { get; set; }
    }
}
