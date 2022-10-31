using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class SO1_VI_01MONITOREORUTEODOCUMENTOSNOENTREGADO
    {
        public string? FolioFactura { get; set; }
        public string? FolioEntrega { get; set; }
        public string FolioRuta { get; set; } = null!;
        public DateTime? FechaCreacionFactura { get; set; }
        public string CodigoCliente { get; set; } = null!;
        public string? NombreCliente { get; set; }
        public int TipoRuta { get; set; }
        public string? ModalidadPago { get; set; }
        public string? Calle { get; set; }
        public string? NoExterior { get; set; }
        public string? NoInterior { get; set; }
        public string? CodigoColonia { get; set; }
        public string? Colonia { get; set; }
        public string? CodigoPostal { get; set; }
        public string? Municipio { get; set; }
        public string? Ciudad { get; set; }
        public string? CodigoEstado { get; set; }
        public string? Estado { get; set; }
        public string? CodigoPais { get; set; }
        public string? Pais { get; set; }
        public decimal SaldoRestante { get; set; }
    }
}
