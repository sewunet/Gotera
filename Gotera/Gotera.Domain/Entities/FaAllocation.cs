using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class FaAllocation
{
    public int Id { get; set; }

    public string EqId { get; set; }

    public int? Project { get; set; }

    public string Ownership { get; set; }

    public int? StartDate { get; set; }

    public int? EstEndDate { get; set; }

    public string Reason { get; set; }

    public string Status { get; set; }

    public string Checked { get; set; }

    public int? Userid { get; set; }

    public int? Userdept { get; set; }

    public char? Trial436 { get; set; }
}
