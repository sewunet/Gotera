using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class TblempPerdiumscale
{
    public int Id { get; set; }

    public decimal? StartSalary { get; set; }

    public decimal? EndSalary { get; set; }

    public decimal? PerdiumAmount { get; set; }

    public char? Trial786 { get; set; }
}
