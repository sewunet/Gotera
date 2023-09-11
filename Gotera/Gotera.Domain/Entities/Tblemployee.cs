using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblemployee
{
    public string EmpId { get; set; }

    public string EmpName { get; set; }

    public decimal? Salary { get; set; }

    public int? EmpDate { get; set; }

    public int? Project { get; set; }

    public int? JobTitleId { get; set; }

    public int? DeptId { get; set; }

    public string Ispermanent { get; set; }

    public decimal? Allowance1 { get; set; }

    public decimal? Allowance2 { get; set; }

    public int? CreatedDate { get; set; }

    public int? UserCreated { get; set; }

    public string Status { get; set; }

    public char? Trial786 { get; set; }
}
