using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class TblempTimecard
{
    public int Id { get; set; }

    public string Employeeid { get; set; }

    public string Employeename { get; set; }

    public int? Projectid { get; set; }

    public string Projectname { get; set; }

    public int? Dateworked { get; set; }

    public int? PeriodYearmonth { get; set; }

    public decimal? HoursworkedMorning { get; set; }

    public decimal? HoursworkedAfternoon { get; set; }

    public decimal? Totalhours { get; set; }

    public decimal? OtNormalHrs { get; set; }

    public decimal? OtWeekendHrs { get; set; }

    public decimal? OtHolidayHrs { get; set; }

    public decimal? OtNightHrs { get; set; }

    public DateTime? Createddate { get; set; }

    public string Createdby { get; set; }

    public bool? Isapproved { get; set; }

    public DateTime? Approveddate { get; set; }

    public string Approvedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public string Updatedby { get; set; }

    public char? Trial786 { get; set; }
}
