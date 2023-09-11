using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Sheet1
{
    public double? Id { get; set; }

    public double? Projectid { get; set; }

    public string Projectname { get; set; }

    public string PlateNo { get; set; }

    public string DriverName { get; set; }

    public double? TrDate { get; set; }

    public double? Period { get; set; }

    public string MaterialType { get; set; }

    public double? LoadingSite { get; set; }

    public double? UnloadingSite { get; set; }

    public string LoadingOfficer { get; set; }

    public string UnloadingOfficer { get; set; }

    public double? NoOfTrips { get; set; }

    public double? HaulingDistance { get; set; }

    public double? ExecutionAmount { get; set; }

    public double? PaidIdleHrs { get; set; }

    public double? PaidIdleAmount { get; set; }

    public string CheckedBy { get; set; }

    public string ApprovedBy { get; set; }

    public string Remark { get; set; }

    public DateTime? DateCreated { get; set; }

    public double? User1 { get; set; }

    public string User2 { get; set; }

    public double? Rate { get; set; }

    public double? Capacity { get; set; }

    public double? PricePerLiter { get; set; }

    public double? FuleTaken { get; set; }

    public double? Isapproved { get; set; }

    public string Approvedby1 { get; set; }

    public DateTime? Approveddate { get; set; }

    public string Updatedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public string Createdby { get; set; }

    public DateTime? Createddate { get; set; }

    public double? ScId { get; set; }

    public string ScName { get; set; }

    public double? Status { get; set; }

    public double? Issendtobill { get; set; }

    public double? MaxKm { get; set; }

    public double? MeterStart { get; set; }

    public double? MeterEnd { get; set; }

    public char? Trial570 { get; set; }
}
