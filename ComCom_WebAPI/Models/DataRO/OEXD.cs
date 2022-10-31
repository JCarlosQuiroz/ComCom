using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OEXD
    {
        public int ExpnsCode { get; set; }
        public string ExpnsName { get; set; } = null!;
        public string? RevAcct { get; set; }
        public string? ExpnsAcct { get; set; }
        public string? TaxLiable { get; set; }
        public decimal? RevFixSum { get; set; }
        public decimal? ExpFixSum { get; set; }
        public string? DataSource { get; set; }
        public short? UserSign { get; set; }
        public string? VatGroupI { get; set; }
        public string? VatGroupO { get; set; }
        public string? DistrbMthd { get; set; }
        public string? In1099 { get; set; }
        public string? ExpOfstAct { get; set; }
        public string? WTLiable { get; set; }
        public string? BaseMethod { get; set; }
        public string? Stock { get; set; }
        public string? LstPchPrce { get; set; }
        public string? SalseRpt { get; set; }
        public string? PchRpt { get; set; }
        public string? RevExmAcct { get; set; }
        public string? ExpnsExAct { get; set; }
        public string? RevRetAct { get; set; }
        public string? ExpnsType { get; set; }
        public string? OcrCode { get; set; }
        public string? TaxDisMthd { get; set; }
        public string? OcrCode2 { get; set; }
        public string? OcrCode3 { get; set; }
        public string? OcrCode4 { get; set; }
        public string? OcrCode5 { get; set; }
        public string? OcrCodeX { get; set; }
        public int? LogInstanc { get; set; }
        public DateTime? UpdateDate { get; set; }
        public short? UserSign2 { get; set; }
        public string? Project { get; set; }
        public string? Intrastat { get; set; }
        public string? GrsFreight { get; set; }
        public string? SacCode { get; set; }
        public string? FreighType { get; set; }
    }
}
