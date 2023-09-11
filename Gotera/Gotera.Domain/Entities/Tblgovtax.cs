using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblgovtax
{
    public int Id { get; set; }

    public string GlAccount { get; set; }

    public string GlDescription { get; set; }

    public string TaxType { get; set; }

    public char? Trial792 { get; set; }
}
