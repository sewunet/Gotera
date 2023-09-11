using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblquotation
{
    public int QuotationId { get; set; }

    public string EqId { get; set; }

    public string PlateNo { get; set; }

    public int? RequestedBy { get; set; }

    public int? CheckedBy { get; set; }

    public int? ApprovedBy { get; set; }

    public int? AuthorizedBy { get; set; }

    public string Remark { get; set; }

    public string Status { get; set; }

    public int? RequestDate { get; set; }

    public int? ApprovedDate { get; set; }

    public string RejectedReason { get; set; }

    public string Assigned { get; set; }

    public int? Technician { get; set; }

    public string Completed { get; set; }

    public int? CompletedDate { get; set; }

    public string TimeTaken { get; set; }

    public string Maintenanceat { get; set; }

    public int? CurrentLocation { get; set; }

    public string JobStatus { get; set; }

    public string InspectionResults { get; set; }

    public char? Trial887 { get; set; }
}
