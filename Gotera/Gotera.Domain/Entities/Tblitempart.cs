using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblitempart
{
    public int ItemId { get; set; }

    public string PartNo { get; set; }

    public char? Trial831 { get; set; }
}
