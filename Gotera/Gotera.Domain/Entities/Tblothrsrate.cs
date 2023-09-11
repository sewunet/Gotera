using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblothrsrate
{
    public int Id { get; set; }

    public decimal? Normalhrsrate { get; set; }

    public decimal? Sundayhrsrate { get; set; }

    public decimal? Holidayhrsrate { get; set; }

    public decimal? Nighthrsrate { get; set; }

    public decimal? Otherhrsrate { get; set; }

    public string Updatedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public string Remark { get; set; }

    public char? Trial841 { get; set; }
}
