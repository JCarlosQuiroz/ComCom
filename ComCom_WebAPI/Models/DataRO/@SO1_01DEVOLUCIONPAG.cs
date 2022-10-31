using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01DEVOLUCIONPAG
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_FOLIO { get; set; }
        public short? U_SO1_NUMPARTIDA { get; set; }
        public string? U_SO1_CODIGOFP { get; set; }
        public int? U_SO1_CHEQUE { get; set; }
        public string? U_SO1_BANCO { get; set; }
        public decimal? U_SO1_MONTONETO { get; set; }
        public string? U_SO1_NUMCUENTA { get; set; }
        public decimal? U_SO1_TIPOCAMBIO { get; set; }
        public DateTime? U_SO1_FECHAVENCIMIEN { get; set; }
        public string? U_SO1_SECUTRANSFE { get; set; }
        public string? U_SO1_MODINGRTARJ { get; set; }
        public string? U_SO1_REFERFINAN { get; set; }
        public string? U_SO1_FOLIODATACAP { get; set; }
    }
}
