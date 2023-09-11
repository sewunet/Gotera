using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Expenserecovery
{
    public int Id { get; set; }

    public decimal? Paymentamount { get; set; }

    public string Paymentdate { get; set; }

    public string Description { get; set; }

    public string Receiptnumber { get; set; }

    public string Signername { get; set; }

    public bool? Isactive { get; set; }

    public string Reason { get; set; }

    public bool? Isdeleted { get; set; }

    public DateTime? Createddate { get; set; }

    public string Createdby { get; set; }

    public bool? Isreviewed { get; set; }

    public DateTime? Revieweddate { get; set; }

    public string Reviewedby { get; set; }

    public bool? Isapproved { get; set; }

    public DateTime? Approveddate { get; set; }

    public string Approvedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public string Updatedby { get; set; }

    public int? Projectid { get; set; }

    public int? Bankid { get; set; }

    public string Checknumber { get; set; }

    public int? Managerid { get; set; }

    public int? Paymentforid { get; set; }

    public decimal? Withholding { get; set; }

    public decimal? Vat { get; set; }

    public string Name { get; set; }

    public string Agreementname { get; set; }

    public int? Agreementid { get; set; }

    public string Projectname { get; set; }

    public string Bankname { get; set; }

    public int? Billid { get; set; }

    public string Billname { get; set; }

    public string Managername { get; set; }

    public int? Payeeid { get; set; }

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

    public bool? Isprinted { get; set; }

    public char? Trial430 { get; set; }
}
