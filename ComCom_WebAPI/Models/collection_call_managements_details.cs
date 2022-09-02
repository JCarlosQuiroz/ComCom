using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_call_managements_details
    {
        public uint id_call_management_detail { get; set; }
        public uint id_call_management { get; set; }
        public uint id_call_management_question { get; set; }
        public uint id_call_management_question_answer { get; set; }
        public uint id_user { get; set; }
        public DateTime answered { get; set; }
    }
}
