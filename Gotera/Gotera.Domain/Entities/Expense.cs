using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Expense
{
    public int Id { get; set; }

    public decimal Paymentamount { get; set; }

    public string Paymentdate { get; set; }

    public string Description { get; set; }

    public string Receiptnumber { get; set; }

    public string Signername { get; set; }

    public bool? Isactive { get; set; }

    public string Reason { get; set; }

    public bool? Isdeleted { get; set; }

    public DateTime Createddate { get; set; }

    public string Createdby { get; set; }

    public bool? Isreviewed { get; set; }

    public DateTime? Revieweddate { get; set; }

    public string Reviewedby { get; set; }

    public bool? Isapproved { get; set; }

    public DateTime? Approveddate { get; set; }

    public string Approvedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public string Updatedby { get; set; }

    public int Projectid { get; set; }

    public int Bankid { get; set; }

    public string Checknumber { get; set; }

    public int? Managerid { get; set; }

    public int? Paymentforid { get; set; }

    public decimal Withholding { get; set; }

    public decimal Vat { get; set; }

    public string Name { get; set; }

    public string Agreementname { get; set; }

    public int? Agreementid { get; set; }

    public string Projectname { get; set; }

    public string Bankname { get; set; }

    public int Billid { get; set; }

    public string Billname { get; set; }

    public string Managername { get; set; }

    public int Payeeid { get; set; }

    public string Payeename { get; set; }

    public string Paymentforname { get; set; }

    public string Accountid { get; set; }

    public int? Agreementtypeid { get; set; }

    public int? ErpDate { get; set; }

    public int? ErpPeriod { get; set; }

    public string PvNo { get; set; }

    public int? ReqId { get; set; }

    public decimal? Billamount { get; set; }

    public string Paymenttype { get; set; }

    public bool? Ispostdated { get; set; }

    public int? Userid { get; set; }

    public bool? Isreconcile { get; set; }

    public string Nameoncheck { get; set; }

    public string Checktype { get; set; }

    public string Payeestatus { get; set; }

    public string Payeestatusname { get; set; }

    public int? Payeestatusid { get; set; }

    public int? Reconcileperiod { get; set; }

    public string Reconcileby { get; set; }

    public string Ownercashieragent { get; set; }

    public bool? Isprinted { get; set; }

    public bool? Isforprint { get; set; }

    public int? Bankstatementid { get; set; }

    public bool? Hascompletedocument { get; set; }

    public string Remark { get; set; }

    public string Auditedby { get; set; }

    public bool? VatRct { get; set; }

    public bool? NoneVatRct { get; set; }

    public bool? WhtRct { get; set; }

    public bool? ContractAgreement { get; set; }

    public bool? PerdiumLetter { get; set; }

    public bool? Advice { get; set; }

    public bool? TradeLicense { get; set; }

    public bool? TinCerteficate { get; set; }

    public bool? VatCerteficate { get; set; }

    public bool? PowerOfAttorney { get; set; }

    public string OtherDocument { get; set; }

    public bool? Isreceivedbyarchive { get; set; }

    public char? Trial417 { get; set; }
}
