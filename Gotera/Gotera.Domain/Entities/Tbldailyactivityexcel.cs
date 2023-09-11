using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tbldailyactivityexcel
{
    public int ActivityId { get; set; }

    public string PlateNo { get; set; }

    public int? ProjectId { get; set; }

    public int? ActivityDate { get; set; }

    public decimal? FuelTaken { get; set; }

    public decimal? TravelledKms { get; set; }

    public int? OperationalHrs { get; set; }

    public int? OperationalMin { get; set; }

    public int? IdlHrs { get; set; }

    public int? IdlMin { get; set; }

    public int? DownHrs { get; set; }

    public int? DownMin { get; set; }

    public int? IdlHrsPaid { get; set; }

    public int? IdlMinPaid { get; set; }

    public string ReasonIdle { get; set; }

    public string ReasonDown { get; set; }

    public string Operator { get; set; }

    public string Usedby { get; set; }

    public decimal? EngineStart { get; set; }

    public decimal? EngineEnd { get; set; }

    public decimal? FuelPrice { get; set; }

    public string Createdby { get; set; }

    public string WeekNo { get; set; }

    public string Remark { get; set; }

    public string Createddate { get; set; }

    public bool? Isapproved { get; set; }

    public string Approvedby { get; set; }

    public DateTime? Approveddate { get; set; }

    public string Source { get; set; }

    public bool? Isvalid { get; set; }

    public string Updatedby { get; set; }

    public string Updateddate { get; set; }

    public int? Operatorid { get; set; }

    public string Operatorname { get; set; }

    public string Telephone { get; set; }

    public char? Trial697 { get; set; }
}
