using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblpayrollcontrol
{
    public int Id { get; set; }

    public int? Period { get; set; }

    public DateTime? Createddate { get; set; }

    public string Createdby { get; set; }

    public bool? Isactive { get; set; }

    public char? Trial848 { get; set; }
}
