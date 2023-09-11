using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class TbltechnicianAssignment
{
    public int AssId { get; set; }

    public int JobId { get; set; }

    public string EqId { get; set; }

    public int? TecId { get; set; }

    public DateTime? AssignedDate { get; set; }

    public string AssignedBy { get; set; }

    public decimal? EstimatedTime { get; set; }

    public string UnitOfTime { get; set; }

    public string Status { get; set; }

    public string TeamLeader { get; set; }

    public char? Trial910 { get; set; }
}
