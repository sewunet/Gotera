using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class BudgetPoAccount
{
    public double? Id { get; set; }

    public double? AccountsId { get; set; }

    public string ExpenseId { get; set; }

    public string RequestType { get; set; }

    public double? RequestId { get; set; }

    public double? AmountPaid { get; set; }

    public char? Trial310 { get; set; }
}
