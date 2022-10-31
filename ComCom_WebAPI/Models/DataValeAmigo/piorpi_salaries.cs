using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class piorpi_salaries
    {
        public uint id_salary { get; set; }
        public byte status { get; set; }
        public uint year { get; set; }
        public byte month { get; set; }
        public decimal salary { get; set; }
    }
}
