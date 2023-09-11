using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Stockitem
{
    public int? Itemid { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public int? GlSalesAccount { get; set; }

    public int? GlInventoryAccount { get; set; }

    public int? GlCostOfSalesAccount { get; set; }

    public char? Trial570 { get; set; }
}
