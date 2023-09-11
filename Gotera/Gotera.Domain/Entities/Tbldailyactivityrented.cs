using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tbldailyactivityrented
{
    public int ActivityId { get; set; }

    public string EqId { get; set; }

    public DateTime? ActivityDate { get; set; }

    public decimal? FuelTaken { get; set; }

    public decimal? OperationalHrs { get; set; }

    public decimal? TravelledKms { get; set; }

    public decimal? IdlHrs { get; set; }

    public decimal? DownHrs { get; set; }

    public string Reason { get; set; }

    public string Reason1 { get; set; }

    public decimal? VolumeOfMaterialMoved { get; set; }

    public decimal? WeightOfMaterialMoved { get; set; }

    public int? OperatorId { get; set; }

    public string Remark { get; set; }

    public string Status { get; set; }

    public char? Trial723 { get; set; }
}
