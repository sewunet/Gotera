using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Eqoutsource
{
    public int Workorderno { get; set; }

    public int? QuotationId { get; set; }

    public int? Sendto { get; set; }

    public decimal? LabourCost { get; set; }

    public decimal? MaterialCost { get; set; }

    public decimal? Vat { get; set; }

    public int? CompletionDate { get; set; }

    public string Remark { get; set; }

    public char? Trial413 { get; set; }
}
