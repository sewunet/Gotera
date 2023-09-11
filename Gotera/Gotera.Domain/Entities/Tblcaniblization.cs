using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblcaniblization
{
    public int Id { get; set; }

    public int? QuotationId { get; set; }

    public string PartName { get; set; }

    public string PartSerialNo { get; set; }

    public decimal? Quantity { get; set; }

    public string PartTakenFrom { get; set; }

    public string ChangedPartLocation { get; set; }

    public string CaniblizeBy { get; set; }

    public int? CanDate { get; set; }

    public string Remark { get; set; }

    public string Status { get; set; }

    public char? Trial655 { get; set; }
}
