using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class TblquotationApproval
{
    public int JobId { get; set; }

    public int QuotationId { get; set; }

    public string EqId { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string ApprovedBy { get; set; }

    public string Status { get; set; }

    public char? Trial890 { get; set; }
}
