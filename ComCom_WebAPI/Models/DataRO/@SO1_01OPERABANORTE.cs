using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01OPERABANORTE
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_FOLIO { get; set; }
        public short? U_SO1_PARTIDACOBPAG { get; set; }
        public string U_SO1_TIPOOPERACION { get; set; } = null!;
        public decimal? U_SO1_MONTO { get; set; }
        public string? U_SO1_REFERENCIAPREV { get; set; }
        public string? U_SO1_CODAUTORPREV { get; set; }
        public short? U_SO1_DIFINICIAL { get; set; }
        public short? U_SO1_NUMEROPAGOS { get; set; }
        public short? U_SO1_TIPOPLAN { get; set; }
        public DateTime? U_SO1_FECHAREQCLIENT { get; set; }
        public int? U_SO1_HORAREQCLIENT { get; set; }
        public DateTime? U_SO1_FECHAREQAUTORI { get; set; }
        public int? U_SO1_HORAREQAUTORIZ { get; set; }
        public DateTime? U_SO1_FECHARESAUTORI { get; set; }
        public int? U_SO1_HORARESAUTORIZ { get; set; }
        public DateTime? U_SO1_FECHARESCLIENT { get; set; }
        public int? U_SO1_HORARESCLIENTE { get; set; }
        public string U_SO1_RESULTADOPAYW { get; set; } = null!;
        public string? U_SO1_CODIGORESPAYW { get; set; }
        public string? U_SO1_RESULTADOAUTO { get; set; }
        public string? U_SO1_CODIGOAUTORIZA { get; set; }
        public string? U_SO1_TEXTORESULTADO { get; set; }
        public string? U_SO1_TARJETAHABIENT { get; set; }
        public string? U_SO1_BANCOEMISOR { get; set; }
        public string? U_SO1_MARCATARJETA { get; set; }
        public string? U_SO1_TIPOTARJETA { get; set; }
        public string? U_SO1_NUMEROTARJETA { get; set; }
        public string? U_SO1_FECHAEXPIRA { get; set; }
        public string? U_SO1_MODOENTRADA { get; set; }
        public string? U_SO1_DATOSEMV { get; set; }
        public string? U_SO1_ARQC { get; set; }
        public string? U_SO1_TVR { get; set; }
        public string? U_SO1_TSI { get; set; }
        public string U_SO1_RESULTADOEVM { get; set; } = null!;
        public string U_SO1_CHIPDECLINADO { get; set; } = null!;
        public string? U_SO1_TAGSEMV { get; set; }
        public string U_SO1_TIPOMOVIMIENTO { get; set; } = null!;
        public string? U_SO1_REFERENCIA { get; set; }
        public string U_SO1_ESTATUS { get; set; } = null!;
        public decimal? U_SO1_MONTOABIERTO { get; set; }
        public string U_SO1_IDTERMINAL { get; set; } = null!;
        public string? U_SO1_CAPTURANIP { get; set; }
    }
}
