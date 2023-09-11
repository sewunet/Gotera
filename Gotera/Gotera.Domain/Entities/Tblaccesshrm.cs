using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblaccesshrm
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public string Username { get; set; }

    public bool? Employee { get; set; }

    public bool? Dailylabourer { get; set; }

    public bool? Jobtitle { get; set; }

    public bool? Taxrate { get; set; }

    public bool? Newpayperiod { get; set; }

    public bool? Timesheet { get; set; }

    public bool? Tsreview { get; set; }

    public bool? Tsapproval { get; set; }

    public bool? Tsreversal { get; set; }

    public bool? Perdiumrequest { get; set; }

    public bool? Perdiumappdept { get; set; }

    public bool? Perdiumprocess { get; set; }

    public bool? Hrreports { get; set; }

    public string Createdby { get; set; }

    public string Createddate { get; set; }

    public string Updatedby { get; set; }

    public string Updateddate { get; set; }

    public bool? Payrollsheet { get; set; }

    public bool? Payrollsummary { get; set; }

    public bool? Denomination { get; set; }

    public bool? Employeelist { get; set; }

    public bool? Docattachemententry { get; set; }

    public bool? Docattachementapp { get; set; }

    public bool? Documenttype { get; set; }

    public bool? Documentreport { get; set; }

    public bool? DlRegistry { get; set; }

    public bool? DlTimesheet { get; set; }

    public bool? DlTimesheetapp { get; set; }

    public bool? DlRegistryList { get; set; }

    public bool? DlTimesheetList { get; set; }

    public bool? DlPayroll { get; set; }

    public bool? DlBudget { get; set; }

    public bool? EmpBudget { get; set; }

    public bool? EmployeePayrollBudgetRequest { get; set; }

    public bool? EmployeePrintPayrollBudget { get; set; }

    public bool? DlPayrollBudgetRequest { get; set; }

    public bool? DlPrintPayrollBudget { get; set; }

    public bool? EmpTimecard { get; set; }

    public bool? Payrollsheetselected { get; set; }

    public bool? Viewpayrollsheet { get; set; }

    public bool? Printpayrollslip { get; set; }

    public bool? Submitpayroll { get; set; }

    public bool? DlTimesheetreview { get; set; }

    public char? Trial593 { get; set; }
}
