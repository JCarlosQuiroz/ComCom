using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OWHT
    {
        public string WTCode { get; set; } = null!;
        public string? WTName { get; set; }
        public decimal? Rate { get; set; }
        public DateTime? EffecDate { get; set; }
        public string? Category { get; set; }
        public string? BaseType { get; set; }
        public decimal? PrctBsAmnt { get; set; }
        public string? OffclCode { get; set; }
        public string? Account { get; set; }
        public decimal? MinTaxAmt { get; set; }
        public string? IsPrgrss { get; set; }
        public string? Type { get; set; }
        public string? RoundType { get; set; }
        public int? WTTypeId { get; set; }
        public string? WTCurrency { get; set; }
        public int? LogInstanc { get; set; }
        public DateTime? UpdateDate { get; set; }
        public short? UserSign { get; set; }
        public int? Section { get; set; }
        public decimal? Threshold { get; set; }
        public decimal? Surcharge { get; set; }
        public string? Concess { get; set; }
        public int? Assessee { get; set; }
        public string? ApTdsAcc { get; set; }
        public string? ApSurAcc { get; set; }
        public string? ApCessAcc { get; set; }
        public string? ApHscAcc { get; set; }
        public string? ArTdsAcc { get; set; }
        public string? ArSurAcc { get; set; }
        public string? ArCessAcc { get; set; }
        public string? ArHscAcc { get; set; }
        public int? Location { get; set; }
        public string? ReturnType { get; set; }
        public short? UserSign2 { get; set; }
        public string? Inactive { get; set; }
        public int? InCSTCode { get; set; }
        public int? OutCSTCode { get; set; }
        public string? CalBaseN { get; set; }
        public string? PymntRsnCd { get; set; }
        public string? DIOTRpt { get; set; }
        public string? TDSType { get; set; }
        public string? ApIgstAcc { get; set; }
        public string? ApCgstAcc { get; set; }
        public string? ApSgstAcc { get; set; }
        public string? ArIgstAcc { get; set; }
        public string? ArCgstAcc { get; set; }
        public string? ArSgstAcc { get; set; }
        public string? ApUtgstAcc { get; set; }
        public string? ApCsgstAcc { get; set; }
        public string? ArUtgstAcc { get; set; }
        public string? ArCsgstAcc { get; set; }
        public string U_B1SYS_FactorType { get; set; } = null!;
    }
}
