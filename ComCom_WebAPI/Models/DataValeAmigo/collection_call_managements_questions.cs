using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_call_managements_questions
    {
        public uint id_call_management_question { get; set; }
        public uint id_call_type { get; set; }
        public string description { get; set; } = null!;
        public byte order { get; set; }
        public byte status { get; set; }
    }
}
