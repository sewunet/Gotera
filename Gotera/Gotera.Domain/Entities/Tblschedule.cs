using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblschedule
{
    public int RecId { get; set; }

    public string EqId { get; set; }

    public int? PmTypeId { get; set; }

    public decimal? PmFrequency { get; set; }

    public int? PmFrequencyBy { get; set; }

    public decimal? PmTolorance { get; set; }

    public string Status { get; set; }

    public char? Trial903 { get; set; }
}
