using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Engmaterial
{
    public int Id { get; set; }

    public int? MtvNo { get; set; }

    public int? GrnNo { get; set; }

    public int? MtvDate { get; set; }

    public int? ProjectId { get; set; }

    public int? Itemid { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Unitprice { get; set; }

    public string Remark { get; set; }

    public string Checked { get; set; }

    public char? Trial403 { get; set; }
}
