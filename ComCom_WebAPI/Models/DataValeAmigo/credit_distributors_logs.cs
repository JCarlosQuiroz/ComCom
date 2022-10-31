using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    /// <summary>
    /// Bitacora de Eventos del Distribuidor
    /// </summary>
    public partial class credit_distributors_logs
    {
        /// <summary>
        /// Identificador de la bitacora
        /// </summary>
        public uint id_distributor_log { get; set; }
        /// <summary>
        /// Identificador del distribuidor
        /// </summary>
        public uint id_distributor { get; set; }
        /// <summary>
        /// Identificador del Usuario
        /// </summary>
        public uint id_user { get; set; }
        /// <summary>
        /// Evento
        /// </summary>
        public byte _event { get; set; }
        /// <summary>
        /// Fecha y Hora del registro
        /// </summary>
        public DateTime registered { get; set; }
        /// <summary>
        /// Nota del evento
        /// </summary>
        public string? note { get; set; }

        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
    }
}
