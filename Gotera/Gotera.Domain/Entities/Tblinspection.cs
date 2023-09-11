using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblinspection
{
    public int JobId { get; set; }

    public string QuotationId { get; set; }

    public string EqId { get; set; }

    public string Recommendation { get; set; }

    public string InspectionResult { get; set; }

    public string ApprovedBy { get; set; }

    public DateTime? DateOfInspection { get; set; }

    public string Status { get; set; }

    public string CompStatus { get; set; }

    public char? Trial818 { get; set; }
}
