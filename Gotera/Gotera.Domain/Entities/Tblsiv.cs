using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblsiv
{
    public int SivId { get; set; }

    public DateTime? Sivdate { get; set; }

    public int? StoreId { get; set; }

    public string SivNo { get; set; }

    public int? IssdBy { get; set; }

    public string RcvdBy { get; set; }

    public int? Userid { get; set; }

    public string IssType { get; set; }

    public string Remark { get; set; }

    public string Refno { get; set; }

    public char? Trial903 { get; set; }
}
