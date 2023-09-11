using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblpart
{
    public int PartId { get; set; }

    public int? ItemId { get; set; }

    public string EqId { get; set; }

    public decimal? Qty { get; set; }

    public string Status { get; set; }

    public char? Trial844 { get; set; }
}
