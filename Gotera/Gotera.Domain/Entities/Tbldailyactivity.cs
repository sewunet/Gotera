using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tbldailyactivity
{
    public int ActivityId { get; set; }

    public string PlateNo { get; set; }

    public string EqId { get; set; }

    public int? ProjectId { get; set; }

    public int? ActivityDate { get; set; }

    public string WeekNo { get; set; }

    public decimal? FuelTaken { get; set; }

    public decimal? TravelledKms { get; set; }

    public int? OperationalHrs { get; set; }

    public int? OperationalMin { get; set; }

    public int? IdlHrs { get; set; }

    public int? IdlMin { get; set; }

    public int? DownHrs { get; set; }

    public int? DownMin { get; set; }

    public string Reason { get; set; }

    public string Reason1 { get; set; }

    public decimal? VolumeOfMaterialMoved { get; set; }

    public decimal? WeightOfMaterialMoved { get; set; }

    public string OperatorId { get; set; }

    public string Remark { get; set; }

    public string Status { get; set; }

    public char? Ownership { get; set; }

    public int? Checked { get; set; }

    public string OidCase { get; set; }

    public string Subcontractor { get; set; }

    public int? IdlHrsPaid { get; set; }

    public int? IdlMinPaid { get; set; }

    public decimal? CurrentRate { get; set; }

    public string Createdby { get; set; }

    public DateTime? Createddate { get; set; }

    public string Updatedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public string Approvedby { get; set; }

    public DateTime? Approveddate { get; set; }

    public bool? Isapproved { get; set; }

    public char? Trial678 { get; set; }
}
