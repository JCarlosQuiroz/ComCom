using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01SALIDAMERDET
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_FOLIO { get; set; }
        public short? U_SO1_NUMPARTIDA { get; set; }
        public string? U_SO1_NUMEROARTICULO { get; set; }
        public decimal? U_SO1_CANTIDAD { get; set; }
        public decimal? U_SO1_PRECIOUNITARIO { get; set; }
        public decimal? U_SO1_IMPORTENETO { get; set; }
        public string? U_SO1_MONEDA { get; set; }
        public decimal? U_SO1_TIPOCAMBIO { get; set; }
        public string? U_SO1_ALMACEN { get; set; }
        public string? U_SO1_CODIGOBARRAS { get; set; }
        public string? U_SO1_DESCRIPCION { get; set; }
        public string U_SO1_SINONIMO { get; set; } = null!;
        public decimal? U_SO1_CANTIDADSINONI { get; set; }
        public string U_SO1_UNIDADMEDIDAIN { get; set; } = null!;
        public string? U_SO1_CODIUNIMEDINV { get; set; }
        public decimal? U_SO1_CANTUNIMEDINV { get; set; }
    }
}
