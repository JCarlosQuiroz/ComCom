using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OITT
    {
        public string Code { get; set; } = null!;
        public string? TreeType { get; set; }
        public short? PriceList { get; set; }
        public decimal? Qauntity { get; set; }
        public string? UseFthrWhs { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? Transfered { get; set; }
        public string? DataSource { get; set; }
        public short? UserSign { get; set; }
        public short? SCNCounter { get; set; }
        public string? DispCurr { get; set; }
        public string? ToWH { get; set; }
        public string? Object { get; set; }
        public int? LogInstac { get; set; }
        public int? UserSign2 { get; set; }
        public string? OcrCode { get; set; }
        public string? HideComp { get; set; }
        public string? OcrCode2 { get; set; }
        public string? OcrCode3 { get; set; }
        public string? OcrCode4 { get; set; }
        public string? OcrCode5 { get; set; }
        public int? UpdateTime { get; set; }
        public string? Project { get; set; }
        public decimal? PlAvgSize { get; set; }
        public string? U_SO1_01CODIGOALT { get; set; }
    }
}
