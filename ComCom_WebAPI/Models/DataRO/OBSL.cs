using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OBSL
    {
        public int AbsEntry { get; set; }
        public int FldAbs { get; set; }
        public string SLCode { get; set; } = null!;
        public string? Descr { get; set; }
        public short? UserSign { get; set; }
        public string? DataSource { get; set; }
        public string? Transfered { get; set; }
        public short? Instance { get; set; }
        public int? LogInstanc { get; set; }
        public DateTime? CreateDate { get; set; }
        public short? UserSign2 { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? Deleted { get; set; }
    }
}
