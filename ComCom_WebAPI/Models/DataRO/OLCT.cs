﻿using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OLCT
    {
        public int Code { get; set; }
        public string Location { get; set; } = null!;
        public short? UserSign { get; set; }
        public string? PanCirNo { get; set; }
        public string? PanWardNo { get; set; }
        public string? PanOfficer { get; set; }
        public string? TanCirNo { get; set; }
        public string? TanWardNo { get; set; }
        public string? TanOfficer { get; set; }
        public string? LstVatNo { get; set; }
        public string? CstNo { get; set; }
        public string? ExemptNo { get; set; }
        public string? TanNo { get; set; }
        public string? ServTaxNo { get; set; }
        public string? AsseType { get; set; }
        public string? CompType { get; set; }
        public string? NatOfBiz { get; set; }
        public string? TinNo { get; set; }
        public string? PanNo { get; set; }
        public string? RegType { get; set; }
        public string? EccNo { get; set; }
        public string? CeRegNo { get; set; }
        public string? CeRange { get; set; }
        public string? CeDivision { get; set; }
        public string? CeComRate { get; set; }
        public string? ManuCode { get; set; }
        public string? Jurisd { get; set; }
        public string? Street { get; set; }
        public string? Block { get; set; }
        public string? ZipCode { get; set; }
        public string? City { get; set; }
        public string? County { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? Building { get; set; }
        public string? SSIExmpt { get; set; }
        public string? SSIExmptSt { get; set; }
        public string? CitAddress { get; set; }
        public string? CitCity { get; set; }
        public string? CitPinCode { get; set; }
        public string? OnHoldAct { get; set; }
        public string? GSTRegnNo { get; set; }
        public string? GSTRelevt { get; set; }
        public string? GSTTDS { get; set; }
        public string? GSTISD { get; set; }
        public int? GSTType { get; set; }
        public string? VendorCode { get; set; }
        public string? CstmerCode { get; set; }
        public string? DropShip { get; set; }
        public string? IngClrAc { get; set; }
        public string? IntBrClrAc { get; set; }
    }
}
