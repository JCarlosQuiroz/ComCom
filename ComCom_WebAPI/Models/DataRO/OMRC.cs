using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OMRC
    {
        public short FirmCode { get; set; }
        public string? FirmName { get; set; }
        public string? DataSource { get; set; }
        public short? UserSign { get; set; }
    }
}
