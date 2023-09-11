using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblmaintenance
{
    public string JobId { get; set; }

    public string EqId { get; set; }

    public DateTime? CompletedDate { get; set; }

    public decimal? TimeTaken { get; set; }

    public string UnitOfTime { get; set; }

    public string ReceivedBy { get; set; }

    public string Status { get; set; }

    public char? Trial838 { get; set; }
}
