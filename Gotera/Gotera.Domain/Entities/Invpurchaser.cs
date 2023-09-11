using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Invpurchaser
{
    public int Id { get; set; }

    public string PurchaserName { get; set; }

    public string Remark { get; set; }

    public string Status { get; set; }

    public string Pass { get; set; }

    public string GlAccount { get; set; }

    public bool? Ispurchaser { get; set; }

    public DateTime? Craeteddate { get; set; }

    public string Createdby { get; set; }

    public char? Trial456 { get; set; }
}
