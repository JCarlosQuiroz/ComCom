using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class coupon_books
    {
        public coupon_books()
        {
            coupon_coupons = new HashSet<coupon_coupons>();
        }

        public uint id_book { get; set; }
        public uint id_distributor { get; set; }
        public uint id_user { get; set; }
        public byte status { get; set; }
        public int quantity { get; set; }
        public DateOnly created { get; set; }
        public DateOnly? delivered { get; set; }
        /// <summary>
        /// Este indica el folio con el que debe iniciar el libro de vouchers
        /// </summary>
        public uint? folio_start { get; set; }

        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
        public virtual ICollection<coupon_coupons> coupon_coupons { get; set; }
    }
}
