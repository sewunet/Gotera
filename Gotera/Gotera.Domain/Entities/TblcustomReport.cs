using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class TblcustomReport
{
    public int Id { get; set; }

    public string Reporttype { get; set; }

    public string Reporttitle { get; set; }

    public string SqlStatement { get; set; }

    public string Createdby { get; set; }

    public DateTime? Createddate { get; set; }

    public string Updatedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public char? Trial678 { get; set; }
}
