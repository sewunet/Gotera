using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class PeachtreeLedger2011
{
    public double? PeachtreeId { get; set; }

    public string TrDate { get; set; }

    public DateTime? Date { get; set; }

    public string Pv { get; set; }

    public string Checkno { get; set; }

    public double? AccountId { get; set; }

    public string AccountDescription { get; set; }

    public DateTime? Date1 { get; set; }

    public string Reference { get; set; }

    public string Jrnl { get; set; }

    public string TransDescription { get; set; }

    public double? DebitAmt { get; set; }

    public double? CreditAmt { get; set; }

    public double? Balance { get; set; }

    public string CustomerId { get; set; }

    public string CustomerName { get; set; }

    public string VendorId { get; set; }

    public string VendorName { get; set; }

    public double? ErpId { get; set; }

    public double? ErpVendorId { get; set; }

    public char? Trial508 { get; set; }
}
