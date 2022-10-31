using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class NNM1
    {
        public string ObjectCode { get; set; } = null!;
        public short Series { get; set; }
        public string SeriesName { get; set; } = null!;
        public int? InitialNum { get; set; }
        public int? NextNumber { get; set; }
        public int? LastNum { get; set; }
        public string? BeginStr { get; set; }
        public string? EndStr { get; set; }
        public string? Remark { get; set; }
        public short? GroupCode { get; set; }
        public string? Locked { get; set; }
        public string? YearTransf { get; set; }
        public string? Indicator { get; set; }
        public string? Template { get; set; }
        public int? NumSize { get; set; }
        public string? FolioPref { get; set; }
        public int? NextFolio { get; set; }
        public string DocSubType { get; set; } = null!;
        public short? DefESeries { get; set; }
        public string? IsDigSerie { get; set; }
        public string SeriesType { get; set; } = null!;
        public string? IsManual { get; set; }
        public int? BPLId { get; set; }
        public string? IsForCncl { get; set; }
        public string? AtDocType { get; set; }
        public string? IsElAuth { get; set; }
    }
}
