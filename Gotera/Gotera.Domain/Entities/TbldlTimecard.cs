using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class TbldlTimecard
{
    public int Id { get; set; }

    public int? Employeeid { get; set; }

    public string Employeename { get; set; }

    public int? Projectid { get; set; }

    public string Projectname { get; set; }

    public decimal? DailyPaymentAmount { get; set; }

    public int? DlWorkingHours { get; set; }

    public int? Dateworked { get; set; }

    public int? PeriodYearmonth { get; set; }

    public decimal? HoursworkedMorning { get; set; }

    public decimal? HoursworkedAfternoon { get; set; }

    public decimal? Totalhours { get; set; }

    public int? OtNormalHrs { get; set; }

    public int? OtWeekendHrs { get; set; }

    public int? OtHolidayHrs { get; set; }

    public int? OtNightHrs { get; set; }

    public decimal? DailyWorkedAmount { get; set; }

    public DateTime? Createddate { get; set; }

    public string Createdby { get; set; }

    public bool? Isapproved { get; set; }

    public DateTime? Approveddate { get; set; }

    public string Approvedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public string Updatedby { get; set; }

    public decimal? DlAmount { get; set; }

    public decimal? DlWorkingHrs { get; set; }

    public int? HireDate { get; set; }

    public decimal? OtNormalAmount { get; set; }

    public decimal? OtWeekendAmount { get; set; }

    public decimal? OtHolidayAmount { get; set; }

    public decimal? OtNightAmount { get; set; }

    public bool? Issendtobill { get; set; }

    public bool? Isreviewed { get; set; }

    public DateTime? Revieweddate { get; set; }

    public string Reviewedby { get; set; }

    public char? Trial733 { get; set; }
}
