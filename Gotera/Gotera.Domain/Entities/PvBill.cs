using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class PvBill
{
    public int Id { get; set; }

    public int? ReqId { get; set; }

    public int? PvNo { get; set; }

    public decimal? AmtBeforeVat { get; set; }

    public decimal? TotPayable { get; set; }

    public decimal? ChequeAmt { get; set; }

    public decimal? Vat { get; set; }

    public decimal? Tot { get; set; }

    public decimal? Wht { get; set; }

    public int? AcctCode { get; set; }

    public int? Bank { get; set; }

    public string ChkNo { get; set; }

    public string Dispersed { get; set; }

    public int? CreatedUser { get; set; }

    public string CreatedDate { get; set; }

    public string PvVoid { get; set; }

    public int? DispersedDate { get; set; }

    public string Description { get; set; }

    public string Signername { get; set; }

    public bool? Isactive { get; set; }

    public string Reason { get; set; }

    public bool? Isdeleted { get; set; }

    public DateTime? Createddate1 { get; set; }

    public string Createdby { get; set; }

    public bool? Isreviewed { get; set; }

    public DateTime? Revieweddate { get; set; }

    public string Reviewedby { get; set; }

    public bool? Isapproved { get; set; }

    public DateTime? Approveddate { get; set; }

    public string Approvedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public string Updatedby { get; set; }

    public int? Managerid { get; set; }

    public int? Paymentforid { get; set; }

    public string Agreementname { get; set; }

    public int? Agreementid { get; set; }

    public string Projectname { get; set; }

    public string Bankname { get; set; }

    public string Managername { get; set; }

    public int? Payeeid { get; set; }

    public string Payeename { get; set; }

    public string Paymentforname { get; set; }

    public int? Agreementtypeid { get; set; }

    public decimal? Grosspayment { get; set; }

    public decimal? Grossescalation { get; set; }

    public decimal? Grossretention { get; set; }

    public decimal? Grossadvance { get; set; }

    public decimal? Grosswithholding { get; set; }

    public decimal? Grossvat { get; set; }

    public decimal? Grossfueldeduction { get; set; }

    public decimal? Grossmaterialdeduction { get; set; }

    public decimal? Grossmachinerydeduction { get; set; }

    public decimal? Grossvehiclededuction { get; set; }

    public decimal? Grosstransportdeduction { get; set; }

    public decimal? Actualadvance { get; set; }

    public bool? Isforpurchase { get; set; }

    public bool? Isforsell { get; set; }

    public decimal? Escalation { get; set; }

    public decimal? Retention { get; set; }

    public int? Projectid { get; set; }

    public decimal? Advancepayment { get; set; }

    public bool? Isforadvance { get; set; }

    public string Payername { get; set; }

    public int? Payerid { get; set; }

    public bool? Ispaid { get; set; }

    public bool? Isincomegenerating { get; set; }

    public decimal? Unpaidamount { get; set; }

    public bool? Deductionapplicable { get; set; }

    public decimal? Grosspaymentamount { get; set; }

    public string Billdate { get; set; }

    public char? Trial524 { get; set; }
}
