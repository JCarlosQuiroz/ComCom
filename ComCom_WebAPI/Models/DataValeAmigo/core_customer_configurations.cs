using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class core_customer_configurations
    {
        public uint id_customer_configuration { get; set; }
        /// <summary>
        /// Nombre de la empresa
        /// </summary>
        public string name { get; set; } = null!;
        /// <summary>
        /// Ruta del logo cuando el menu esta expandido
        /// </summary>
        public string expanded_logo { get; set; } = null!;
        /// <summary>
        /// Ruta del logo cuando esta contraido el menu
        /// </summary>
        public string contracted_logo { get; set; } = null!;
        /// <summary>
        /// Estilo a emplear para el sitio
        /// </summary>
        public string style { get; set; } = null!;
        /// <summary>
        /// Fecha en que se dio de alta
        /// </summary>
        public DateTime created { get; set; }
    }
}
