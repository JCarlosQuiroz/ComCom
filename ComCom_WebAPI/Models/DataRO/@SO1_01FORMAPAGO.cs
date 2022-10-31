using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01FORMAPAGO
    {
        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public int DocEntry { get; set; }
        public string? Canceled { get; set; }
        public string? Object { get; set; }
        public int? LogInst { get; set; }
        public int? UserSign { get; set; }
        public string? Transfered { get; set; }
        public DateTime? CreateDate { get; set; }
        public short? CreateTime { get; set; }
        public DateTime? UpdateDate { get; set; }
        public short? UpdateTime { get; set; }
        public string? DataSource { get; set; }
        public string U_SO1_TIPOFORMAPAGO { get; set; } = null!;
        public string U_SO1_PERMITEDARCAMB { get; set; } = null!;
        public string U_SO1_ABRECAJONVAL { get; set; } = null!;
        public short U_SO1_TARJETABANC { get; set; }
        public string U_SO1_DINERO { get; set; } = null!;
        public string U_SO1_ACEPTAEXCEDENT { get; set; } = null!;
        public string U_SO1_NUMEROTARJETA { get; set; } = null!;
        public string U_SO1_NUMAUTORIZA { get; set; } = null!;
        public string U_SO1_NUMIDENPERSONA { get; set; } = null!;
        public string U_SO1_NUMEROTELEFONO { get; set; } = null!;
        public string U_SO1_NUMEROTRANSFER { get; set; } = null!;
        public string U_SO1_FECHATRANSFER { get; set; } = null!;
        public string U_SO1_FECHACHEQUE { get; set; } = null!;
        public string? U_SO1_MONEDA { get; set; }
        public string U_SO1_TECLAFUNCION { get; set; } = null!;
        public string U_SO1_DEPOSITOSBANCA { get; set; } = null!;
        public decimal U_SO1_PORCENCOMISION { get; set; }
        public string? U_SO1_CARTICCOMISION { get; set; }
        public string? U_SO1_NARTICCOMISION { get; set; }
        public string U_SO1_DESGLDETCORTEX { get; set; } = null!;
        public string U_SO1_INCLCOMISIONFP { get; set; } = null!;
        public string U_SO1_CONTABPAGODOCU { get; set; } = null!;
        public string U_SO1_ACTIVRESMONCOB { get; set; } = null!;
        public decimal? U_SO1_MONTOMAXCOBRO { get; set; }
        public decimal? U_SO1_MONTOMAXCAMBIO { get; set; }
        public string U_SO1_TIPOINTERFAZ { get; set; } = null!;
        public string U_SO1_PROMOCIONMESES { get; set; } = null!;
        public short? U_SO1_MESESPROMOCION { get; set; }
        public string U_SO1_CONINTERESES { get; set; } = null!;
        public string U_SO1_MOSNUMCUENPAGO { get; set; } = null!;
        public string U_SO1_NUMCUENPAGOBLI { get; set; } = null!;
        public string U_SO1_BLOQUEARCOBRO { get; set; } = null!;
        public string? U_SO1_METODOPAGOOTRO { get; set; }
        public string U_SO1_09ECHOONE { get; set; } = null!;
        public string U_SO1_VALIDARCERTIFI { get; set; } = null!;
        public string U_SO1_ACTCAMPOEXTCHE { get; set; } = null!;
        public string? U_SO1_MAPCAMPEXTCHE { get; set; }
        public string U_SO1_VENFORZA { get; set; } = null!;
        public string U_SO1_TIPOFPCHILE { get; set; } = null!;
        public string U_SO1_USARDIFERIMINI { get; set; } = null!;
        public short? U_SO1_MESESDIFERINIC { get; set; }
        public string? U_SO1_DESCCORTAFPVT { get; set; }
        public string U_SO1_VISFECHACHEQUE { get; set; } = null!;
        public string U_SO1_VISNUMTARJETA { get; set; } = null!;
        public string U_SO1_VISNUMATORIZA { get; set; } = null!;
        public string U_SO1_VISNUMTEL { get; set; } = null!;
        public string U_SO1_VISNUMIDPERSON { get; set; } = null!;
        public string U_SO1_VISNUMTRANSF { get; set; } = null!;
        public string U_SO1_VISFECHTRANSF { get; set; } = null!;
        public string? U_SO1_CATARTEXCLU { get; set; }
        public string U_SO1_EBT { get; set; } = null!;
        public string U_SO1_TIPOEBT { get; set; } = null!;
        public string U_SO1_AMERICANEXPRES { get; set; } = null!;
    }
}
