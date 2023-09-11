using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Eqworkshop
{
    public int Id { get; set; }

    public int? QuotationId { get; set; }

    public int? ItemId { get; set; }

    public decimal? Qty { get; set; }

    public string Remark { get; set; }

    public char? Trial417 { get; set; }
}
