using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class CRD4
    {
        public string CardCode { get; set; } = null!;
        public string WTCode { get; set; } = null!;
        public int? LogInstanc { get; set; }
    }
}
