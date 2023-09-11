using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblautopo
{
    public int PoNo { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? Createddate { get; set; }

    public string Createdby { get; set; }

    public char? Trial645 { get; set; }
}
