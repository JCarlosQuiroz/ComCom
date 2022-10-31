using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01TRASPASODET
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_FOLIO { get; set; }
        public string? U_SO1_NUMEROARTICULO { get; set; }
        public short? U_SO1_NUMPARTIDA { get; set; }
        public decimal? U_SO1_CANTIDAD { get; set; }
        public decimal? U_SO1_CANTIDADAB { get; set; }
        public decimal? U_SO1_PRECIO { get; set; }
        public decimal? U_SO1_IMPORTE { get; set; }
        public string? U_SO1_MONEDA { get; set; }
        public decimal? U_SO1_TIPOCAMBIO { get; set; }
        public int? U_SO1_INSTANCIA { get; set; }
        public string? U_SO1_CODIGOBARRAS { get; set; }
        public string? U_SO1_DESCRIPCION { get; set; }
        public string U_SO1_SINONIMO { get; set; } = null!;
        public decimal? U_SO1_CANTIDADSINONI { get; set; }
        public short? U_SO1_PARTIDABASE { get; set; }
        public string? U_SO1_ARTICULOGENERI { get; set; }
        public decimal? U_SO1_CANTIDADEQUIVA { get; set; }
        public string? U_SO1_TIPODOCBASE { get; set; }
        public string? U_SO1_DOCBASE { get; set; }
        public string U_SO1_TIPOPARTIDA { get; set; } = null!;
        public decimal? U_SO1_CANTIDEQUIVAAB { get; set; }
        public decimal? U_SO1_CANTIDADSUGE { get; set; }
        public decimal? U_SO1_CANTIDADSOLI { get; set; }
        public decimal? U_SO1_CANTIDADSEPA { get; set; }
        public decimal? U_SO1_CANTIDADTRAS { get; set; }
        public string U_SO1_UNIDADMEDIDAIN { get; set; } = null!;
        public string? U_SO1_CODIUNIMEDINV { get; set; }
        public decimal? U_SO1_CANTUNIMEDINV { get; set; }
        public string? U_SO1_TIPOOPER12PERU { get; set; }
        public string? U_SO1_TIPOOPER12ENTP { get; set; }
        public decimal? U_SO1_CANTIARTIGENER { get; set; }
        public decimal? U_SO1_CANTEXISTENCIA { get; set; }
        public decimal? U_SO1_CANTPROPUESTA { get; set; }
    }
}
