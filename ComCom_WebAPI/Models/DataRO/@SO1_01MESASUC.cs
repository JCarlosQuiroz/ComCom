using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01MESASUC
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_TIPO { get; set; }
        public string? U_SO1_NOMBRE { get; set; }
        public string? U_SO1_SUCURSAL { get; set; }
        public string? U_SO1_ESTATUS { get; set; }
        public string? U_SO1_AREA { get; set; }
        public decimal? U_SO1_POSICIONX { get; set; }
        public decimal? U_SO1_POSICIONY { get; set; }
        public decimal? U_SO1_ANCHO { get; set; }
        public decimal? U_SO1_ALTO { get; set; }
        public short? U_SO1_NUMERO { get; set; }
        public string? U_SO1_BOTONID { get; set; }
        public short? U_SO1_COMENSALES { get; set; }
        public string? U_SO1_COMANDAACTIVA { get; set; }
        public int? U_SO1_MESERO { get; set; }
        public string? U_SO1_MESAPADRE { get; set; }
        public decimal? U_SO1_ANCHOPANEL { get; set; }
        public decimal? U_SO1_ALTOPANEL { get; set; }
        public string? U_SO1_FOLIOESPERA { get; set; }
        public decimal? U_SO1_ANGULOROTACION { get; set; }
    }
}
