using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblitemrequest
{
    public int ItemRequestId { get; set; }

    public int? UserId { get; set; }

    public string Reqby { get; set; }

    public DateTime? ExpectedDate { get; set; }

    public DateTime? RequestedDate { get; set; }

    public int? RequestStatusId { get; set; }

    public DateTime? StatusDate { get; set; }

    public int? SiteId { get; set; }

    public string Remarks { get; set; }

    public int? Refsrno { get; set; }

    public int? JobId { get; set; }

    public long? Transactid { get; set; }

    public int? Tier1appby { get; set; }

    public int? Tier2appby { get; set; }

    public int? Tier3appby { get; set; }

    public char? Trial835 { get; set; }
}
