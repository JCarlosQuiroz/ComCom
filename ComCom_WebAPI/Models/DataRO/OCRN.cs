using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OCRN
    {
        public string CurrCode { get; set; } = null!;
        public string? CurrName { get; set; }
        public string? ChkName { get; set; }
        public string? Chk100Name { get; set; }
        public string? DocCurrCod { get; set; }
        public string? FrgnName { get; set; }
        public string? F100Name { get; set; }
        public string? Locked { get; set; }
        public string? DataSource { get; set; }
        public short? UserSign { get; set; }
        public short? RoundSys { get; set; }
        public short? UserSign2 { get; set; }
        public short? Decimals { get; set; }
        public string? ISRCalc { get; set; }
        public string? RoundPym { get; set; }
        public string? ConvUnit { get; set; }
        public string? BaseCurr { get; set; }
        public decimal? Factor { get; set; }
        public string? ChkNamePl { get; set; }
        public string? Chk100NPl { get; set; }
        public string? FrgnNamePl { get; set; }
        public string? F100NamePl { get; set; }
        public string? ISOCurrCod { get; set; }
        public decimal? MaxInDiff { get; set; }
        public decimal? MaxOutDiff { get; set; }
        public decimal? MaxInPcnt { get; set; }
        public decimal? MaxOutPcnt { get; set; }
        public string? ISOCurrNum { get; set; }
        public string U_SO1_01COBROR1 { get; set; } = null!;
        public string U_SO1_01DISPONIBILR1 { get; set; } = null!;
    }
}
