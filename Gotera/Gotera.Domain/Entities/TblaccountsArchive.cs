using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class TblaccountsArchive
{
    public int Id { get; set; }

    public string Recordtype { get; set; }

    public int? VendorCustomerId { get; set; }

    public string VendorCustomerName { get; set; }

    public string GlAccount { get; set; }

    public string GlDescription { get; set; }

    public decimal? GlDebit { get; set; }

    public decimal? GlCredit { get; set; }

    public int? TranDate { get; set; }

    public string InvoiceNo { get; set; }

    public int? Job { get; set; }

    public string JobId { get; set; }

    public string JobName { get; set; }

    public string Reference { get; set; }

    public string FsNo { get; set; }

    public string Boxfileno { get; set; }

    public int? Budgetyear { get; set; }

    public string PvNo { get; set; }

    public string JvNo { get; set; }

    public string PettycashNo { get; set; }

    public string Remark { get; set; }

    public string CashReceiptNo { get; set; }

    public DateTime? Createddate { get; set; }

    public string Createdby { get; set; }

    public bool? Isreviewed { get; set; }

    public string Revieweddate { get; set; }

    public string Reviewedby { get; set; }

    public bool? Isapproved { get; set; }

    public string Approveddate { get; set; }

    public string Approvedby { get; set; }

    public bool? Isbankaccount { get; set; }

    public bool? Isfromsource { get; set; }

    public bool? Ispostdated { get; set; }

    public string Statusofpayee { get; set; }

    public int? Nameoncheckid { get; set; }

    public string Nameoncheckname { get; set; }

    public string Typeofpayment { get; set; }

    public string Checknumberorreference { get; set; }

    public string PlateNo { get; set; }

    public string Updatedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public bool? Ispaid { get; set; }

    public int? Checkissuedate { get; set; }

    public string Signername { get; set; }

    public bool? Isvoidcheck { get; set; }

    public bool? Hascompletedocument { get; set; }

    public decimal? Servicecharge { get; set; }

    public int? Bankstatementid { get; set; }

    public bool? Isprojectaccounts { get; set; }

    public bool? Isrental { get; set; }

    public string Transubtype { get; set; }

    public string PoNpo { get; set; }

    public string Reqid { get; set; }

    public bool? Isreplenished { get; set; }

    public int? CashReceiptDate { get; set; }

    public bool? Ispurchase { get; set; }

    public bool? Isprojectpettycash { get; set; }

    public string MrcNumber { get; set; }

    public bool? Ischeckconfirmed { get; set; }

    public int? Zohoid { get; set; }

    public bool? Isbegining { get; set; }

    public char? Trial599 { get; set; }
}
