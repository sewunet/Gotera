using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblaccountsetup
{
    public int Id { get; set; }

    public string VatGlAccount { get; set; }

    public string WhtGlAccount { get; set; }

    public string DefaultBankAccount { get; set; }

    public char? Trial642 { get; set; }
}
