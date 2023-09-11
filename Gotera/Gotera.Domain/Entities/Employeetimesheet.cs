using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Employeetimesheet
{
    public int Id { get; set; }

    public string Employeeid { get; set; }

    public string Employeename { get; set; }

    public decimal? Hourlyrate { get; set; }

    public decimal? Salary { get; set; }

    public decimal? Absenthrs { get; set; }

    public decimal? Regularhours { get; set; }

    public decimal? Weekdayovertimes { get; set; }

    public decimal? Weekendovertimes { get; set; }

    public decimal? Holidayovertimes { get; set; }

    public decimal? Nightovertimes { get; set; }

    public string Reason { get; set; }

    public DateTime? Createddate { get; set; }

    public string Createdby { get; set; }

    public bool? Isreviewed { get; set; }

    public DateTime? Revieweddate { get; set; }

    public string Reviewedby { get; set; }

    public bool? Isapproved { get; set; }

    public DateTime? Approveddate { get; set; }

    public string Approvedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public string Updatedby { get; set; }

    public int? Projectid { get; set; }

    public decimal? Hourlyperdiemrate { get; set; }

    public decimal? Percentdeduction { get; set; }

    public bool? Hasloan { get; set; }

    public decimal? Loandeduction { get; set; }

    public decimal? Loanamount { get; set; }

    public int? Paymentperiod { get; set; }

    public int? Paidperiods { get; set; }

    public int? Loanstartperiod { get; set; }

    public decimal? Perdiemhours { get; set; }

    public string Title { get; set; }

    public decimal? Basicsalary { get; set; }

    public string Allowancetypes { get; set; }

    public decimal? Allowance { get; set; }

    public decimal? AllowancePerdium { get; set; }

    public decimal? AllowanceDesert { get; set; }

    public decimal? Regularpayment { get; set; }

    public decimal? Perdiempayment { get; set; }

    public decimal? Totalovertimepayment { get; set; }

    public decimal? Employeepension { get; set; }

    public decimal? Employerpension { get; set; }

    public decimal? Grosssalary { get; set; }

    public decimal? Tax { get; set; }

    public decimal? Familyallotment { get; set; }

    public decimal? Costsharing { get; set; }

    public decimal? Totaldeduction { get; set; }

    public decimal? Netpay { get; set; }

    public decimal? Totalpayment { get; set; }

    public string Projectname { get; set; }

    public bool? Isdeleted { get; set; }

    public bool? Isactive { get; set; }

    public int? Period { get; set; }

    public int? Deptid { get; set; }

    public string Deptname { get; set; }

    public bool? Issendtobill { get; set; }

    public decimal? DesertAllowanceDays { get; set; }

    public bool? Isprinted { get; set; }

    public bool? Issubmitted { get; set; }

    public int? Printbatchno { get; set; }

    public string Employeefamilyname { get; set; }

    public string Employeefamilybankname { get; set; }

    public string Employeefamilybankaccount { get; set; }

    public decimal? FoodDeduction { get; set; }

    public char? Trial237 { get; set; }
}
