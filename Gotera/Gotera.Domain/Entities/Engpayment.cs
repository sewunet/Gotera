using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Engpayment
{
    public int ReqId { get; set; }

    public int? Trdate { get; set; }

    public int? Expecteddate { get; set; }

    public string BudgetMonth { get; set; }

    public int? BudgetYear { get; set; }

    public int? Project { get; set; }

    public decimal? Amount { get; set; }

    public int? SubContractor { get; set; }

    public string Descr { get; set; }

    public int? AmountPercent { get; set; }

    public int? Status { get; set; }

    public int? Userid { get; set; }

    public decimal? ApprovedAmount { get; set; }

    public string Pvno { get; set; }

    public int? PydDate { get; set; }

    public decimal? PaidAmount { get; set; }

    public char? Trial403 { get; set; }
}
