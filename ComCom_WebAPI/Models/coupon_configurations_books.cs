using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class coupon_configurations_books
    {
        public uint id_configuration_book { get; set; }
        public uint id_user { get; set; }
        /// <summary>
        /// Este campo define el tipo de folio para el voucher, 1 por sistema, 2 por usuario
        /// </summary>
        public byte folio_type { get; set; }
        /// <summary>
        /// Este campo tiene el estado del layout, 1 activado, 2 desactivado
        /// </summary>
        public byte layout_status { get; set; }
        /// <summary>
        /// Este campo tiene el estado del limit, 1 con limite, 2 sin limite
        /// </summary>
        public byte limit_status { get; set; }
        /// <summary>
        /// Este campo define el limite de cupones para generar
        /// </summary>
        public uint? limit_amount { get; set; }
        public DateOnly created_date { get; set; }

        public virtual core_users id_userNavigation { get; set; } = null!;
    }
}
