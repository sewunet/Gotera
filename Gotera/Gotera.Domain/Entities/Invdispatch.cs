using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Invdispatch
{
    public int Id { get; set; }

    public int? Ref { get; set; }

    public int? ItemId { get; set; }

    public string DeliveryType { get; set; }

    public decimal? Qty { get; set; }

    public decimal? QtyApp { get; set; }

    public int? Project { get; set; }

    public int? Subcontractor { get; set; }

    public int? Employee { get; set; }

    public string Status { get; set; }

    public int? Applevel { get; set; }

    public int? TrDate { get; set; }

    public int? Userid2 { get; set; }

    public char? Trial452 { get; set; }
}
