﻿using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CODBARDETVENT
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string U_SO1_TIPO { get; set; } = null!;
        public int? U_SO1_NUMCARACT { get; set; }
    }
}
