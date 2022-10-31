using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OSRN
    {
        public string ItemCode { get; set; } = null!;
        public int? SysNumber { get; set; }
        public string? DistNumber { get; set; }
        public string? MnfSerial { get; set; }
        public string? LotNumber { get; set; }
        public DateTime? ExpDate { get; set; }
        public DateTime? MnfDate { get; set; }
        public DateTime? InDate { get; set; }
        public DateTime? GrntStart { get; set; }
        public DateTime? GrntExp { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Location { get; set; }
        public string? Status { get; set; }
        public string? Notes { get; set; }
        public string? DataSource { get; set; }
        public short? UserSign { get; set; }
        public string? Transfered { get; set; }
        public short? Instance { get; set; }
        public int? AbsEntry { get; set; }
        public string? ObjType { get; set; }
        public string? itemName { get; set; }
        public int? LogInstanc { get; set; }
        public short? UserSign2 { get; set; }
        public DateTime? UpdateDate { get; set; }
        public decimal? CostTotal { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QuantOut { get; set; }
        public decimal? PriceDiff { get; set; }
        public decimal? Balance { get; set; }
        public int? TrackingNt { get; set; }
        public int? TrackiNtLn { get; set; }
        public short? SumDec { get; set; }
        public string? U_EsPedimento { get; set; }
    }
}
