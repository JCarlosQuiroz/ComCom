using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    /// <summary>
    /// Actualizado a 18 Mayo
    /// IsdarkA
    /// </summary>
    public partial class core_sepomex
    {
        public uint id_sepomex { get; set; }
        /// <summary>
        /// Código Postal asentamiento
        /// </summary>
        public uint d_codigo { get; set; }
        /// <summary>
        /// Nombre asentamiento
        /// </summary>
        public string? d_asenta { get; set; }
        /// <summary>
        /// Tipo de asentamiento (Catálogo SEPOMEX)
        /// </summary>
        public string? d_tipo_asenta { get; set; }
        /// <summary>
        /// Nombre Municipio (INEGI, Marzo 2013)
        /// </summary>
        public string? D_mnpio { get; set; }
        /// <summary>
        /// Nombre Entidad (INEGI, Marzo 2013)
        /// </summary>
        public string? d_estado { get; set; }
        /// <summary>
        /// Nombre Ciudad (Catálogo SEPOMEX)
        /// </summary>
        public string? d_ciudad { get; set; }
        /// <summary>
        /// Código Postal de la Administración Postal que reparte al asentamiento
        /// </summary>
        public int? d_CP { get; set; }
        /// <summary>
        /// Clave Entidad (INEGI, Marzo 2013)
        /// </summary>
        public int? c_estado { get; set; }
        /// <summary>
        /// Código Postal de la Administración Postal que reparte al asentamiento
        /// </summary>
        public int? c_oficina { get; set; }
        /// <summary>
        /// Campo Vacio
        /// </summary>
        public string? c_CP { get; set; }
        /// <summary>
        /// Clave Tipo de asentamiento (Catálogo SEPOMEX)
        /// </summary>
        public int? c_tipo_asenta { get; set; }
        /// <summary>
        /// Clave Municipio (INEGI, Marzo 2013)
        /// </summary>
        public int? c_mnpio { get; set; }
        /// <summary>
        /// Identificador Único del asentamiento (nivel municipal)
        /// 
        /// </summary>
        public int? id_asenta_cpcons { get; set; }
        /// <summary>
        /// Zona en la que se ubica el asentamiento (Urbano/Rural)
        /// </summary>
        public string? d_zona { get; set; }
        /// <summary>
        /// Clave Ciudad (Catálogo SEPOMEX)
        /// </summary>
        public int? c_cve_ciudad { get; set; }
        public sbyte? status { get; set; }
    }
}
