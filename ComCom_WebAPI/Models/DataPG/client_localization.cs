using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class client_localization
    {
        public int id { get; set; }
        public string? coordinates { get; set; }
        public int fk_client_id { get; set; }

        public virtual client fk_client { get; set; } = null!;
    }
}
