using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01DOCSIGNCHIDET
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_CODIGODOCUELEC { get; set; }
        public string U_SO1_TIPOELEMXML { get; set; } = null!;
        public string? U_SO1_NOMBREELEMEXML { get; set; }
        public string? U_SO1_PADRE { get; set; }
        public string? U_SO1_TIPOVALOR { get; set; }
        public string? U_SO1_VAORVARIABLE { get; set; }
        public string? U_SO1_TEXTOOMAPEO { get; set; }
        public short? U_SO1_ORDEN { get; set; }
        public string? U_SO1_REPETICIONPOR { get; set; }
        public string? U_SO1_FORMATO { get; set; }
        public string? U_SO1_IDALTERNO { get; set; }
        public string? U_SO1_PADREALTERNO { get; set; }
    }
}
