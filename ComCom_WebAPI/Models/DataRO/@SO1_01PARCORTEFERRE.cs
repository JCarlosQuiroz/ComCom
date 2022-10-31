using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01PARCORTEFERRE
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? U_SO1_FOLIO { get; set; }
        public short? U_SO1_NUMPARTIDA { get; set; }
        public string? U_SO1_ARTICULOCORTE { get; set; }
        public string? U_SO1_ARTICULOROSCA { get; set; }
        public short? U_SO1_NUMEROROSCAS { get; set; }
        public decimal? U_SO1_LARGOROSCAS { get; set; }
        public decimal? U_SO1_NUMEROCORTES { get; set; }
        public string U_SO1_UNIDADMEDIDA { get; set; } = null!;
        public decimal? U_SO1_LARGONIPLEPERN { get; set; }
        public decimal? U_SO1_PRECIONIPLEPER { get; set; }
        public decimal? U_SO1_FACTOR1 { get; set; }
        public decimal? U_SO1_FACTOR2 { get; set; }
        public decimal? U_SO1_FACTOR3 { get; set; }
        public decimal? U_SO1_FACTOR4 { get; set; }
    }
}
