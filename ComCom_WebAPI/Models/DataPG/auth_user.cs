using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class auth_user
    {
        public auth_user()
        {
            auth_user_groups = new HashSet<auth_user_groups>();
            auth_user_user_permissions = new HashSet<auth_user_user_permissions>();
            client = new HashSet<client>();
            client_historicalrmusers = new HashSet<client_historicalrmusers>();
            deposit_credit = new HashSet<deposit_credit>();
            deposit_debit = new HashSet<deposit_debit>();
            django_admin_log = new HashSet<django_admin_log>();
            file_imported_credit = new HashSet<file_imported_credit>();
            voucher = new HashSet<voucher>();
        }

        public int id { get; set; }
        public string password { get; set; } = null!;
        public DateTime? last_login { get; set; }
        public bool is_superuser { get; set; }
        public string username { get; set; } = null!;
        public string first_name { get; set; } = null!;
        public string last_name { get; set; } = null!;
        public string email { get; set; } = null!;
        public bool is_staff { get; set; }
        public bool is_active { get; set; }
        public DateTime date_joined { get; set; }

        public virtual ICollection<auth_user_groups> auth_user_groups { get; set; }
        public virtual ICollection<auth_user_user_permissions> auth_user_user_permissions { get; set; }
        public virtual ICollection<client> client { get; set; }
        public virtual ICollection<client_historicalrmusers> client_historicalrmusers { get; set; }
        public virtual ICollection<deposit_credit> deposit_credit { get; set; }
        public virtual ICollection<deposit_debit> deposit_debit { get; set; }
        public virtual ICollection<django_admin_log> django_admin_log { get; set; }
        public virtual ICollection<file_imported_credit> file_imported_credit { get; set; }
        public virtual ICollection<voucher> voucher { get; set; }
    }
}
