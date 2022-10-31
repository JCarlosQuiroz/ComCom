using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01PROMOPUN
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime? U_SO1_FECHADESDE { get; set; }
        public DateTime? U_SO1_FECHAHASTA { get; set; }
        public decimal? U_SO1_PROCENTAJEPROM { get; set; }
        public string U_SO1_APLICAPARTDESC { get; set; } = null!;
        public string U_SO1_TIPOCRITERIO { get; set; } = null!;
        public string U_SO1_PORCADA { get; set; } = null!;
        public decimal? U_SO1_IMPORCANT { get; set; }
        public int? U_SO1_PUNTOS { get; set; }
        public string U_SO1_ACTPORCADA { get; set; } = null!;
    }
}
