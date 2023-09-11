using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblmrp
{
    public int RecId { get; set; }

    public string QuotationId { get; set; }

    public int? JobId { get; set; }

    public string EqId { get; set; }

    public int? ItemId { get; set; }

    public decimal? QtyRequired { get; set; }

    public int? MrpDate { get; set; }

    public string Remark { get; set; }

    public string Sendtostore { get; set; }

    public string PlateNo { get; set; }

    public char? Trial841 { get; set; }
}
