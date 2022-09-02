using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class reference_person
    {
        public int id { get; set; }
        public string full_name { get; set; } = null!;
        public string phone_number { get; set; } = null!;
        public string relationship { get; set; } = null!;
        public string? address { get; set; }
        public int fk_residential_client_id { get; set; }

        public virtual residential_client fk_residential_client { get; set; } = null!;
    }
}
