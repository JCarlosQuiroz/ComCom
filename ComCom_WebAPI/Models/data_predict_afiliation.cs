using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class data_predict_afiliation
    {
        public int id { get; set; }
        public int id_application { get; set; }
        public int id_distributor { get; set; }
        public bool? morabinary { get; set; }
        public string? risk { get; set; }
        public DateTime? date { get; set; }
    }
}
