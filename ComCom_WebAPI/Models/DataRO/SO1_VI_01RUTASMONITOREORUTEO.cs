using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class SO1_VI_01RUTASMONITOREORUTEO
    {
        public string FolioRuta { get; set; } = null!;
        public string? CodigoTransportista { get; set; }
        public string? NombreTransportista { get; set; }
        public string? CodigoVehiculo { get; set; }
        public string? DescripcionVehiculo { get; set; }
        public decimal? CapacidadCargaVehiculo { get; set; }
        public decimal? PesoRuta { get; set; }
        public decimal? CargaSobrante { get; set; }
        public int TipoRuta { get; set; }
        public string? ColorEstado { get; set; }
        public string? EstadoActual { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public short? HoraCreacion { get; set; }
        public string? HoraCreacionCadena { get; set; }
        public int? UsuarioCreacion { get; set; }
        public string? NombreUsuarioCreacion { get; set; }
        public string? EstacionCreacion { get; set; }
        public DateTime? FechaInicioCarga { get; set; }
        public short? HoraInicioCarga { get; set; }
        public string? HoraInicioCargaCadena { get; set; }
        public int? UsuarioInicioCarga { get; set; }
        public string? NombreUsuarioInicioCarga { get; set; }
        public string? EstacionInicioCarga { get; set; }
        public DateTime? FechaFinCarga { get; set; }
        public short? HoraFinCarga { get; set; }
        public string? HoraFinCargaCadena { get; set; }
        public int? UsuarioFinCarga { get; set; }
        public string? NombreUsuarioFinCarga { get; set; }
        public string? EstacionFinCarga { get; set; }
        public DateTime? FechaSalidaAduana { get; set; }
        public short? HoraSalidaAduana { get; set; }
        public string? HoraSalidaAduanaCadena { get; set; }
        public int? UsuarioSalidaAduana { get; set; }
        public string? NombreUsuarioSalidaAduana { get; set; }
        public string? EstacionSalidaAduana { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public short? HoraRecepcion { get; set; }
        public string? HoraRecepcionCadena { get; set; }
        public int? UsuarioRecepcion { get; set; }
        public string? NombreUsuarioRecepcion { get; set; }
        public string? EstacionRecepcion { get; set; }
        public string? NombreUsuarioFin { get; set; }
    }
}
