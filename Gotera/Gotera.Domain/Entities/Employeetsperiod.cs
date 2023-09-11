using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Employeetsperiod
{
    public int TsPeriod { get; set; }

    public string Status { get; set; }

    public string Remark { get; set; }

    public string Createdby { get; set; }

    public string Createdtime { get; set; }

    public DateTime? Updateddate { get; set; }

    public string Updatedby { get; set; }

    public char? Trial257 { get; set; }
}
