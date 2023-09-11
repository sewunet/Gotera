using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Invdeliverytran
{
    public int Id { get; set; }

    public int? ItemId { get; set; }

    public decimal? Qty { get; set; }

    public string RecType { get; set; }

    public int? Ref { get; set; }

    public int? Project { get; set; }

    public string DeliveryType { get; set; }

    public int? TranDate { get; set; }

    public string Status { get; set; }

    public decimal? UnitPrice { get; set; }

    public int? Userid1 { get; set; }

    public int? Userid2 { get; set; }

    public string Remark { get; set; }

    public char? Trial446 { get; set; }
}
