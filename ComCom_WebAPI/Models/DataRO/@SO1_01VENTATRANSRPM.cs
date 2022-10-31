using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01VENTATRANSRPM
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public int? U_SO1_IDTRANSACCION { get; set; }
        public string? U_SO1_FOLIOVENTA { get; set; }
        public int? U_SO1_IDCLIENTE { get; set; }
        public int? U_SO1_IDSUCURSAL { get; set; }
        public int? U_SO1_IDESTACION { get; set; }
        public int? U_SO1_IDCAJERO { get; set; }
        public int? U_SO1_IDPRODUCTO { get; set; }
        public decimal? U_SO1_MONTO { get; set; }
        public string? U_SO1_REFERENCIA1 { get; set; }
        public string? U_SO1_REFERENCIA2 { get; set; }
        public string? U_SO1_REFERENCIA3 { get; set; }
        public string? U_SO1_CODIGORESP { get; set; }
        public string? U_SO1_MENSAJERESP { get; set; }
        public int? U_SO1_IDTRANSACRESP { get; set; }
        public DateTime? U_SO1_FECHA { get; set; }
        public string? U_SO1_NUMEAUTOPROVEE { get; set; }
        public string? U_SO1_INFORMALEGAL { get; set; }
        public string? U_SO1_INFOADICIONAL1 { get; set; }
        public string? U_SO1_INFOADICIONAL2 { get; set; }
        public string? U_SO1_INFOADICIONAL3 { get; set; }
        public string U_SO1_SERVICIOWEB { get; set; } = null!;
        public string U_SO1_ESTATUS { get; set; } = null!;
    }
}
