using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_circulo_credito
    {
        public uint id_circulo_credito { get; set; }
        public uint id_application { get; set; }
        public byte status { get; set; }
        public DateTime datetime { get; set; }
        public string? note { get; set; }
        public byte[] request { get; set; } = null!;
        public byte[]? response { get; set; }
        public string? folio { get; set; }

        public virtual origination_applications id_applicationNavigation { get; set; } = null!;
    }
}
