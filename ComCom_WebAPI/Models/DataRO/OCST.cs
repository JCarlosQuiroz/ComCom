using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OCST
    {
        public string Code { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string? Name { get; set; }
        public short? UserSign { get; set; }
        public short? eCode { get; set; }
        public string? GNRECode { get; set; }
        public string? GSTCode { get; set; }
        public string? GSTIsUT { get; set; }
        public string? U_SO1_02CLAVESAT { get; set; }
        public string? U_SO1_01CODEDO { get; set; }
    }
}
