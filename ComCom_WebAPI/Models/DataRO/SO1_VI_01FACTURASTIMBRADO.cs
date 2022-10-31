using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class SO1_VI_01FACTURASTIMBRADO
    {
        public bool? Seleccion { get; set; }
        public string TipoDocumento { get; set; } = null!;
        public string? FolioDoc { get; set; }
        public string? Fecha { get; set; }
        public decimal? Importe { get; set; }
        public string Estado { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string? Tipo { get; set; }
    }
}
