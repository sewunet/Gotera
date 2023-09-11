using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblsivdetail
{
    public int Id { get; set; }

    public int? SivId { get; set; }

    public int? ItemId { get; set; }

    public int? Condid { get; set; }

    public decimal? Qtyissd { get; set; }

    public decimal? Unitprice { get; set; }

    public string Refno { get; set; }

    public char? Trial906 { get; set; }
}
