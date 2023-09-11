using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblrecovery
{
    public int Pid { get; set; }

    public int? Project { get; set; }

    public int? PvNo { get; set; }

    public string Paid { get; set; }

    public string Cash { get; set; }

    public int? Sc { get; set; }

    public char? Trial893 { get; set; }
}
