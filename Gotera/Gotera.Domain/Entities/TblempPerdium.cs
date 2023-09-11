using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class TblempPerdium
{
    public int Id { get; set; }

    public string EmpId { get; set; }

    public int? TrDate { get; set; }

    public string DepartureDate { get; set; }

    public decimal? Salary { get; set; }

    public decimal? PerdiumScale { get; set; }

    public int? PerdiumPercent { get; set; }

    public decimal? PerdiumAmount { get; set; }

    public decimal? FreightCost { get; set; }

    public decimal? NoOfDays { get; set; }

    public string TravelFrom { get; set; }

    public string TravelTo { get; set; }

    public decimal? Transport { get; set; }

    public int? UserId { get; set; }

    public int? UserDept { get; set; }

    public string Status { get; set; }

    public int? CostProject { get; set; }

    public char? Trial782 { get; set; }
}
