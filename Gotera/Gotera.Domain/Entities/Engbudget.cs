using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Engbudget
{
    public int Id { get; set; }

    public int? RequestId { get; set; }

    public int? BudgetPeriod { get; set; }

    public int? Expecteddate { get; set; }

    public string BudgetType { get; set; }

    public int? Trdate { get; set; }

    public int? Project { get; set; }

    public int? Subcontractor { get; set; }

    public string Descr { get; set; }

    public decimal? RequestedAmount { get; set; }

    public decimal? ApprovedAmount { get; set; }

    public string Remark { get; set; }

    public int? Userid { get; set; }

    public int? ApprovedBy { get; set; }

    public string ReceivedBy { get; set; }

    public string Checked { get; set; }

    public string PlateNo { get; set; }

    public char? Trial266 { get; set; }
}
