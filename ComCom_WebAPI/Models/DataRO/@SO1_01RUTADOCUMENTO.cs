using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01RUTADOCUMENTO
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public short? U_SO1_NUMEROLINEA { get; set; }
        public string? U_SO1_FOLIORUTA { get; set; }
        public string? U_SO1_FOLIOVENTA { get; set; }
        public decimal? U_SO1_SALDOPENDIENTE { get; set; }
        public string? U_SO1_DOCUMENDESTINO { get; set; }
        public DateTime? U_SO1_FECHARECEPCION { get; set; }
        public short? U_SO1_HORARECEPCION { get; set; }
        public string? U_SO1_HORARECEPCADEN { get; set; }
        public string? U_SO1_COMENTARIO { get; set; }
        public string? U_SO1_TIPOENTREGA { get; set; }
        public string? U_SO1_DEVOLUCIONDEST { get; set; }
        public string U_SO1_ACCIONNOENTREG { get; set; } = null!;
        public string? U_SO1_CODMOTIVORETRA { get; set; }
        public string? U_SO1_DESCMOTIVRETRA { get; set; }
        public DateTime? U_SO1_FECHAREPROGRAM { get; set; }
    }
}
