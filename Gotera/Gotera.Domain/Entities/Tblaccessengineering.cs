using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblaccessengineering
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public string Username { get; set; }

    public bool? Subcontractor { get; set; }

    public bool? Site { get; set; }

    public bool? Unitofmeasure { get; set; }

    public bool? Station { get; set; }

    public bool? Billgroup { get; set; }

    public bool? Payitems { get; set; }

    public bool? Payitemssc { get; set; }

    public bool? Backupsheet { get; set; }

    public bool? Backupsheetsc { get; set; }

    public bool? Priceadjustment { get; set; }

    public bool? Timesheetentry { get; set; }

    public bool? Allocation { get; set; }

    public int? Allocationapproval { get; set; }

    public bool? Eqdailyactivity { get; set; }

    public int? Timesheetapproval { get; set; }

    public bool? Timesheetlist { get; set; }

    public bool? Timesheetstatus { get; set; }

    public bool? Timesheetsummary { get; set; }

    public bool? Timesheetreport { get; set; }

    public string Createdby { get; set; }

    public string Createddate { get; set; }

    public string Updatedby { get; set; }

    public string Updateddate { get; set; }

    public bool? Projectexpense { get; set; }

    public bool? Screport { get; set; }

    public bool? Allocatedresources { get; set; }

    public bool? Projectreports { get; set; }

    public bool? Ipcreports { get; set; }

    public bool? Expectedcosts { get; set; }

    public bool? Backupsheetmainapp { get; set; }

    public bool? Backupsheetscapp { get; set; }

    public bool? Timesheetappdaily { get; set; }

    public bool? DeductionEntry { get; set; }

    public bool? DeductionApproval { get; set; }

    public bool? DeductionReport { get; set; }

    public bool? M3kmcontract { get; set; }

    public bool? Dailyactivitykm { get; set; }

    public bool? Dailyactivitykmapp { get; set; }

    public char? Trial583 { get; set; }
}
