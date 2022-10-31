using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01DEVOLUCIONRET
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_FOLIO { get; set; }
        public short? U_SO1_LINEA { get; set; }
        public string? U_SO1_CODIGORETEN { get; set; }
        public string U_SO1_TIPORETENCION { get; set; } = null!;
        public decimal? U_SO1_TARIFA { get; set; }
        public string U_SO1_TIPOBASE { get; set; } = null!;
        public decimal? U_SO1_PORCENTAJEBASE { get; set; }
        public decimal? U_SO1_IMPORTEBASE { get; set; }
        public decimal? U_SO1_IMPORTESUJETO { get; set; }
        public decimal? U_SO1_IMPORTERETEN { get; set; }
    }
}
