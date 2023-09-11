using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class CfRevenue
{
    public int Id { get; set; }

    public int? DateRcvd { get; set; }

    public int? Period { get; set; }

    public int? Project { get; set; }

    public string PaymentNo { get; set; }

    public int? Payer { get; set; }

    public int? BankId { get; set; }

    public string ChkNo { get; set; }

    public decimal? ActualAmt { get; set; }

    public decimal? Wht { get; set; }

    public decimal? Vat { get; set; }

    public decimal? AdvDeduction { get; set; }

    public decimal? Retention { get; set; }

    public decimal? Other { get; set; }

    public decimal? ExcecutedRev { get; set; }

    public string Remark { get; set; }

    public int? Userid { get; set; }

    public int? CreatedDate { get; set; }

    public string Checked { get; set; }

    public string JvNo { get; set; }

    public char? Trial314 { get; set; }
}
