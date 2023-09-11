using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblaccountbegining
{
    public int Id { get; set; }

    public string GlAccount { get; set; }

    public string GlDescription { get; set; }

    public int? VendorCustomerId { get; set; }

    public string VendorCustomerName { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public char? Trial596 { get; set; }
}
