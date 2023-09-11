using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class TblregistryOwned
{
    public int Id { get; set; }

    public string PlateNo { get; set; }

    public string EqId { get; set; }

    public string EqName { get; set; }

    public int? Category { get; set; }

    public string EqModel { get; set; }

    public int? Manufacturer { get; set; }

    public string YearOfManufacturing { get; set; }

    public string PurchaseDate { get; set; }

    public decimal? HorsePower { get; set; }

    public string EngineNo { get; set; }

    public string ChassisNo { get; set; }

    public string PolicyNo { get; set; }

    public decimal? Capacity { get; set; }

    public int? FuelType { get; set; }

    public string EngineArrNo { get; set; }

    public string TmNo { get; set; }

    public string Status { get; set; }

    public string Remark { get; set; }

    public string ManualFilename { get; set; }

    public string CreatedBy { get; set; }

    public int? ProjId { get; set; }

    public string Ownership { get; set; }

    public string RentingCompany { get; set; }

    public decimal? RentRate { get; set; }

    public decimal? IdlerentRate { get; set; }

    public string Agreement { get; set; }

    public int? MinH { get; set; }

    public int? MinM { get; set; }

    public string Description { get; set; }

    public string Machinerynumber { get; set; }

    public bool? Isoperational { get; set; }

    public string Reason { get; set; }

    public decimal? Fuelconsumptionrate { get; set; }

    public decimal? Fuelholdingcapacity { get; set; }

    public bool? Isdeleted { get; set; }

    public DateTime? Createddate { get; set; }

    public string Createdby1 { get; set; }

    public bool? Isreviewed { get; set; }

    public DateTime? Revieweddate { get; set; }

    public string Reviewedby { get; set; }

    public bool? Isapproved { get; set; }

    public DateTime? Approveddate { get; set; }

    public string Approvedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public string Updatedby { get; set; }

    public int? Equipmenttypeid { get; set; }

    public int? Odometerreading { get; set; }

    public int? Clientid { get; set; }

    public decimal? Machinecapacity { get; set; }

    public bool? Isactive { get; set; }

    public bool? Ismachinery { get; set; }

    public bool? Isvehicletransport { get; set; }

    public int? ExpiryDate { get; set; }

    public bool? Hasvat { get; set; }

    public bool? Haswht { get; set; }

    public decimal? VatInPercent { get; set; }

    public decimal? WhtInPercent { get; set; }

    public int? Operatorid { get; set; }

    public string Operatorname { get; set; }

    public char? Trial897 { get; set; }
}
