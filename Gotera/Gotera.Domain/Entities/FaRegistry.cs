using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class FaRegistry
{
    public int Id { get; set; }

    public string EqId { get; set; }

    public int? Ref { get; set; }

    public string ItemName { get; set; }

    public int? CatId { get; set; }

    public decimal? OriginalCost { get; set; }

    public int? PurchaseDate { get; set; }

    public int? LifeTime { get; set; }

    public decimal? SalvageValue { get; set; }

    public int? Project { get; set; }

    public string Remark { get; set; }

    public string Status { get; set; }

    public string Checked { get; set; }

    public char? Trial436 { get; set; }
}
