using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01DEVOLUCIONDET
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? U_SO1_DESCRIPCION { get; set; }
        public string? U_SO1_MONEDA { get; set; }
        public decimal? U_SO1_TIPOCAMBIO { get; set; }
        public decimal? U_SO1_IMPUESTO { get; set; }
        public short? U_SO1_PARTIDAVENTA { get; set; }
        public string? U_SO1_FOLIO { get; set; }
        public short? U_SO1_NUMPARTIDA { get; set; }
        public string? U_SO1_NUMEROARTICULO { get; set; }
        public decimal? U_SO1_CANTIDAD { get; set; }
        public decimal? U_SO1_PBSD { get; set; }
        public decimal? U_SO1_PBCD { get; set; }
        public decimal? U_SO1_PNSD { get; set; }
        public decimal? U_SO1_PNCD { get; set; }
        public decimal? U_SO1_DESCUENTO { get; set; }
        public int? U_SO1_VENDEDOR { get; set; }
        public decimal? U_SO1_IMPORTENETO { get; set; }
        public string? U_SO1_ALMACEN { get; set; }
        public string? U_SO1_CODIGOBARRAS { get; set; }
        public string U_SO1_SINONIMO { get; set; } = null!;
        public decimal? U_SO1_CANTIDADSINONI { get; set; }
        public string U_SO1_NOCATALOGADO { get; set; } = null!;
        public string? U_SO1_RETENCION { get; set; }
        public decimal? U_SO1_PESOTEORICO { get; set; }
        public decimal? U_SO1_PESOREAL { get; set; }
        public decimal? U_SO1_DCTOPORCENTDX1 { get; set; }
        public decimal? U_SO1_DCTOPORCENTDX2 { get; set; }
        public string? U_SO1_CODIGOIMPUESTO { get; set; }
        public decimal? U_SO1_IMPUESTOPRCNT { get; set; }
        public string? U_SO1_FOLIOCONSOLID { get; set; }
        public decimal? U_SO1_CIFTOTALPARTID { get; set; }
        public decimal? U_SO1_IMPUESTOCIF { get; set; }
        public decimal? U_SO1_TIPOCAMBMONCIF { get; set; }
        public decimal? U_SO1_PORCENTIMPUCIF { get; set; }
        public string U_SO1_UNIDADMEDIDAIN { get; set; } = null!;
        public string? U_SO1_CODIUNIMEDINV { get; set; }
        public decimal? U_SO1_CANTUNIMEDINV { get; set; }
        public string? U_SO1_TIPOOPER12PERU { get; set; }
        public short? U_SO1_PARTIDAPADRE { get; set; }
        public string U_SO1_AFECTAINVETARI { get; set; } = null!;
        public string U_SO1_CANCELPENDIENT { get; set; } = null!;
        public string? U_SO1_PEDIMENTO { get; set; }
    }
}
