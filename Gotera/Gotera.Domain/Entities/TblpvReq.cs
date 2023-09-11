using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class TblpvReq
{
    public int Id { get; set; }

    public string PvNo { get; set; }

    public int? ReqId { get; set; }

    public string Paymenttype { get; set; }

    public decimal? ErpAmount { get; set; }

    public decimal? PaidAmount { get; set; }

    public string AccountCode { get; set; }

    public string Accountname { get; set; }

    public int? Projectid { get; set; }

    public int? Userid { get; set; }

    public bool? Isactive { get; set; }

    public int? Agreementtypeid { get; set; }

    public int? Agreementid { get; set; }

    public string Agreementname { get; set; }

    public bool? Issubmitted { get; set; }

    public int? Payeeid { get; set; }

    public string Payeename { get; set; }

    public string Statusofpayee { get; set; }

    public int? Nameoncheckid { get; set; }

    public string Nameoncheckname { get; set; }

    public string Typeofpayment { get; set; }

    public char? Trial877 { get; set; }
}
