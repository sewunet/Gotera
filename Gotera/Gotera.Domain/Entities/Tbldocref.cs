using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tbldocref
{
    public int Id { get; set; }

    public int? Refdocid { get; set; }

    public int? Reftousrid { get; set; }

    public int? Refbyusrid { get; set; }

    public DateTime? Refdate { get; set; }

    public int? Refstatusid { get; set; }

    public char? Trial779 { get; set; }
}
