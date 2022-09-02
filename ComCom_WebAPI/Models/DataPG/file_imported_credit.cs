using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class file_imported_credit
    {
        public int id { get; set; }
        public string imported_file { get; set; } = null!;
        public DateOnly created_date { get; set; }
        public int? created_by_id { get; set; }

        public virtual auth_user? created_by { get; set; }
    }
}
