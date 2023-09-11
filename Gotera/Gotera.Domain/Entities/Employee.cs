using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Employee
{
    public int Id { get; set; }

    public string EmpName { get; set; }

    public string Firstname { get; set; }

    public string Middlename { get; set; }

    public string Lastname { get; set; }

    public string Employeeid { get; set; }

    public int? Vendorid { get; set; }

    public bool? Isactive { get; set; }

    public bool? Ispermanent { get; set; }

    public string Reason { get; set; }

    public bool? Isdeleted { get; set; }

    public int? Hiredate { get; set; }

    public string Terminateddate { get; set; }

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

    public decimal? Hourlyrate { get; set; }

    public decimal? Salary { get; set; }

    public decimal? PositionAllowance { get; set; }

    public decimal? Familyallotment { get; set; }

    public decimal? Costsharing { get; set; }

    public decimal? Hourlyperdiemrate { get; set; }

    public int? Desertallowancepercent { get; set; }

    public string Title { get; set; }

    public int? Titleid { get; set; }

    public int? Serviceagreementid { get; set; }

    public int? Deptid { get; set; }

    public string Deptname { get; set; }

    public string Employeebankname { get; set; }

    public string Employeebankaccount { get; set; }

    public string Employeefamilyname { get; set; }

    public string Employeefamilybankname { get; set; }

    public string Employeefamilybankaccount { get; set; }

    public string TinNo { get; set; }

    public string PensionNo { get; set; }

    public char? Trial230 { get; set; }
}
