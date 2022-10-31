using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class DSC1
    {
        public string BankCode { get; set; } = null!;
        public string Account { get; set; } = null!;
        public string? Branch { get; set; }
        public int? NextCheck { get; set; }
        public string? GLAccount { get; set; }
        public string? Free { get; set; }
        public string? Street { get; set; }
        public string? Block { get; set; }
        public string? ZipCode { get; set; }
        public string? City { get; set; }
        public string? County { get; set; }
        public string Country { get; set; } = null!;
        public string? State { get; set; }
        public string? BISR { get; set; }
        public string? ControlKey { get; set; }
        public string? UsrNumber1 { get; set; }
        public string? UsrNumber2 { get; set; }
        public string? UsrNumber3 { get; set; }
        public string? UsrNumber4 { get; set; }
        public string? IBAN { get; set; }
        public string? DscountBOE { get; set; }
        public int? TolrnceDay { get; set; }
        public decimal? MinAmntBOE { get; set; }
        public decimal? MaxAmntBOE { get; set; }
        public decimal? DscntLimit { get; set; }
        public int? DaysInAdva { get; set; }
        public string? BankCollec { get; set; }
        public string? BankDiscou { get; set; }
        public string? BranchName { get; set; }
        public string? AliasName { get; set; }
        public string? CompanyCod { get; set; }
        public string? AcctType { get; set; }
        public string? Building { get; set; }
        public string? BIK { get; set; }
        public string? AcctName { get; set; }
        public string? CorresAcct { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? GLIntriAct { get; set; }
        public string? ChkPaper { get; set; }
        public short? MaxChkLine { get; set; }
        public string? TmpltName { get; set; }
        public int AbsEntry { get; set; }
        public int? BankKey { get; set; }
        public string? LockChk { get; set; }
        public int? OurNum { get; set; }
        public string? AgreeNum { get; set; }
        public string? AccountChk { get; set; }
        public short? ISRType { get; set; }
        public string? ISRBillerI { get; set; }
        public string? CustIdNum { get; set; }
        public short? InSeri { get; set; }
        public short? OutSeri { get; set; }
        public short? JDTSeri { get; set; }
        public string? FilePlug { get; set; }
        public string? ImpStmt { get; set; }
        public string? PreNumber { get; set; }
        public string? AddrType { get; set; }
        public string? StreetNo { get; set; }
        public int? LogInstanc { get; set; }
        public DateTime? UpdateDate { get; set; }
        public short? UsrLogSign { get; set; }
        public short? UserSign2 { get; set; }
        public string? SwiftNum { get; set; }
        public string? FineAcct { get; set; }
        public string? IntrstAcct { get; set; }
        public string? DscntAcct { get; set; }
        public string? SvcFeeAcct { get; set; }
        public string? BranchChk { get; set; }
        public string? RetFile { get; set; }
        public string? IOFTaxAcct { get; set; }
        public string? OthExpAcct { get; set; }
        public string? OthIncAcct { get; set; }
        public string? CollCode { get; set; }
        public int? FileSeqNNo { get; set; }
        public string? RefCoLevel { get; set; }
        public short? RefFixLen1 { get; set; }
        public short? RefFixLen2 { get; set; }
        public string? Currency { get; set; }
    }
}
