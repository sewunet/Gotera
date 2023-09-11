using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class TbldlRegistry
{
    public int Employeeid { get; set; }

    public string Employeename { get; set; }

    public int? Jobid { get; set; }

    public string Jobtitle { get; set; }

    public int? Projectid { get; set; }

    public string Projectname { get; set; }

    public string Projectmanagername { get; set; }

    public int? Sectionid { get; set; }

    public string Sectionname { get; set; }

    public string Sectionleader { get; set; }

    public decimal? DlAmount { get; set; }

    public decimal? DlWorkingHrs { get; set; }

    public int? HireDate { get; set; }

    public string Remark { get; set; }

    public DateTime? Createddate { get; set; }

    public string Createdby { get; set; }

    public DateTime? Approveddate { get; set; }

    public string Approvedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public string Updatedby { get; set; }

    public bool? Isactive { get; set; }

    public string Employeebankname { get; set; }

    public string Employeebankaccount { get; set; }

    public string Employeefamilyname { get; set; }

    public string Employeefamilybankname { get; set; }

    public string Employeefamilybankaccount { get; set; }

    public bool? ExcludePension { get; set; }

    public char? Trial730 { get; set; }
}
