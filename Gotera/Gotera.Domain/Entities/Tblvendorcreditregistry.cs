using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblvendorcreditregistry
{
    public int Id { get; set; }

    public string PvNo { get; set; }

    public int? Sourceid { get; set; }

    public string Rectype { get; set; }

    public int? PoReqNo { get; set; }

    public decimal? TotalAmount { get; set; }

    public string Reqid { get; set; }

    public char? Trial923 { get; set; }
}
