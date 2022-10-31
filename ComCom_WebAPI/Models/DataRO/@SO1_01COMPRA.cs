using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01COMPRA
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_PROVEEDOR { get; set; }
        public DateTime? U_SO1_FECHA { get; set; }
        public short? U_SO1_HORA { get; set; }
        public string? U_SO1_HORACADENA { get; set; }
        public string? U_SO1_SUCURSAL { get; set; }
        public string? U_SO1_ESTACION { get; set; }
        public int? U_SO1_USUARIO { get; set; }
        public string? U_SO1_TIPO { get; set; }
        public string U_SO1_STATUS { get; set; } = null!;
        public string U_SO1_DOCDESTINO { get; set; } = null!;
        public string? U_SO1_REFERENCIA { get; set; }
        public int? U_SO1_CONDICIONCREDI { get; set; }
        public int? U_SO1_DIASCREDITO { get; set; }
        public DateTime? U_SO1_FECHAENTREGA { get; set; }
        public decimal? U_SO1_DESCUENTOACUM1 { get; set; }
        public decimal? U_SO1_DESCUENTOACUM2 { get; set; }
        public int? U_SO1_CONCEPTOGASTOS { get; set; }
        public decimal? U_SO1_IMPORTEGASTOS { get; set; }
        public string? U_SO1_COMENTARIO { get; set; }
        public string? U_SO1_MONEDA { get; set; }
        public decimal? U_SO1_TIPOCAMBIO { get; set; }
        public decimal? U_SO1_DCTOPORCENTAJE { get; set; }
        public decimal? U_SO1_DCTOMONTO { get; set; }
        public decimal? U_SO1_TOTALNETO { get; set; }
        public decimal? U_SO1_TOTALNETOMONED { get; set; }
        public decimal? U_SO1_GASTOSNETO { get; set; }
        public string? U_SO1_INDICAIMPUESTO { get; set; }
        public decimal? U_SO1_TASAIMPUESTO { get; set; }
        public string U_SO1_AUTORIZADO { get; set; } = null!;
        public string U_SO1_SINCRONIZADO { get; set; } = null!;
        public string? U_SO1_FOLIOCORTEX { get; set; }
        public string? U_SO1_PREFIJO { get; set; }
        public int? U_SO1_FOLIO { get; set; }
        public DateTime? U_SO1_FECHACONTABILI { get; set; }
        public DateTime? U_SO1_FECHADOCUMENTO { get; set; }
        public DateTime? U_SO1_FECHAVENCIMIEN { get; set; }
        public string? U_SO1_ARCHIVOPDF { get; set; }
        public string? U_SO1_ARCHIVOXML { get; set; }
        public decimal? U_SO1_TOTALFISICO { get; set; }
        public string? U_SO1_FOLIOUUID { get; set; }
        public string U_SO1_REPARTIDO { get; set; } = null!;
        public string? U_SO1_VERSIONR1 { get; set; }
        public DateTime? U_SO1_FECHACANCELOC { get; set; }
        public string? U_SO1_PROVEEDORSEC { get; set; }
        public string? U_SO1_FOLIOREFOC { get; set; }
        public string U_SO1_RECEPCIONPARCI { get; set; } = null!;
        public string? U_SO1_FOLIOFAINTER { get; set; }
    }
}
