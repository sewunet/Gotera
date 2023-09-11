using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblpurque
{
    public int PurqId { get; set; }

    public int? ItemId { get; set; }

    public int? StoreId { get; set; }

    public DateTime? Qdate { get; set; }

    public int? Reqdetailid { get; set; }

    public int? QstatusId { get; set; }

    public DateTime? QstatusDate { get; set; }

    public bool Qprocessed { get; set; }

    public decimal? Qqty { get; set; }

    public char? Trial877 { get; set; }
}
