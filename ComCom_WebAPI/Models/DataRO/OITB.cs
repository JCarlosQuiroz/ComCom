using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OITB
    {
        public short ItmsGrpCod { get; set; }
        public string ItmsGrpNam { get; set; } = null!;
        public string? Locked { get; set; }
        public string? DataSource { get; set; }
        public short? UserSign { get; set; }
        public string? BalInvntAc { get; set; }
        public string? SaleCostAc { get; set; }
        public string? TransferAc { get; set; }
        public string? RevenuesAc { get; set; }
        public string? VarianceAc { get; set; }
        public string? DecreasAc { get; set; }
        public string? IncreasAc { get; set; }
        public string? ReturnAc { get; set; }
        public string? ExpensesAc { get; set; }
        public string? EURevenuAc { get; set; }
        public string? EUExpensAc { get; set; }
        public string? FrRevenuAc { get; set; }
        public string? FrExpensAc { get; set; }
        public string? ExmptIncom { get; set; }
        public short? CycleCode { get; set; }
        public string? Alert { get; set; }
        public string? PriceDifAc { get; set; }
        public string? ExchangeAc { get; set; }
        public string? BalanceAcc { get; set; }
        public string? PurchaseAc { get; set; }
        public string? PAReturnAc { get; set; }
        public string? PurchOfsAc { get; set; }
        public string? ShpdGdsAct { get; set; }
        public string? VatRevAct { get; set; }
        public string? DecresGlAc { get; set; }
        public string? IncresGlAc { get; set; }
        public string? InvntSys { get; set; }
        public string? PlaningSys { get; set; }
        public string? PrcrmntMtd { get; set; }
        public short? OrdrIntrvl { get; set; }
        public decimal? OrdrMulti { get; set; }
        public decimal? MinOrdrQty { get; set; }
        public int? LeadTime { get; set; }
        public string? StokRvlAct { get; set; }
        public string? StkOffsAct { get; set; }
        public string? WipAcct { get; set; }
        public string? WipVarAcct { get; set; }
        public string? CostRvlAct { get; set; }
        public string? CstOffsAct { get; set; }
        public string? ExpClrAct { get; set; }
        public string? ExpOfstAct { get; set; }
        public string? Object { get; set; }
        public int? logInstanc { get; set; }
        public DateTime? createDate { get; set; }
        public short? userSign2 { get; set; }
        public DateTime? updateDate { get; set; }
        public string? ARCMAct { get; set; }
        public string? ARCMFrnAct { get; set; }
        public string? ARCMEUAct { get; set; }
        public string? ARCMExpAct { get; set; }
        public string? APCMAct { get; set; }
        public string? APCMFrnAct { get; set; }
        public string? APCMEUAct { get; set; }
        public string? RevRetAct { get; set; }
        public string? ItemClass { get; set; }
        public int? OSvcCode { get; set; }
        public int? ISvcCode { get; set; }
        public int? ServiceGrp { get; set; }
        public int? NCMCode { get; set; }
        public string? MatType { get; set; }
        public int? MatGrp { get; set; }
        public string? ProductSrc { get; set; }
        public string? NegStckAct { get; set; }
        public string? StkInTnAct { get; set; }
        public string? PurBalAct { get; set; }
        public string? WhICenAct { get; set; }
        public string? WhOCenAct { get; set; }
        public string? WipOffset { get; set; }
        public string? StockOffst { get; set; }
        public int? UgpEntry { get; set; }
        public int? IUoMEntry { get; set; }
        public int? ToleranDay { get; set; }
        public string? RuleCode { get; set; }
        public string? CompoWH { get; set; }
        public string? FreeChrgSA { get; set; }
        public string? FreeChrgPU { get; set; }
        public string? U_LINEA { get; set; }
        public string U_SO1_01ACTIVO { get; set; } = null!;
        public decimal? U_SO1_01FACTOR { get; set; }
        public decimal? U_SO1_01PERMITIDO { get; set; }
    }
}
