using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class TbldlDeduction
{
    public int Id { get; set; }

    public int? Employeeid { get; set; }

    public string Employeename { get; set; }

    public decimal? DeductionAmount { get; set; }

    public string DeductionRemark { get; set; }

    public int? Period { get; set; }

    public int? TranDate { get; set; }

    public int? Projectid { get; set; }

    public string Projectname { get; set; }

    public bool? Isapproved { get; set; }

    public DateTime? Approveddate { get; set; }

    public string Approvedby { get; set; }

    public bool? Isactive { get; set; }

    public DateTime? Createddate { get; set; }

    public string Createdby { get; set; }

    public string Updatedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public decimal? Food { get; set; }

    public decimal? Loan { get; set; }

    public decimal? ReturnablePenality { get; set; }

    public char? Trial727 { get; set; }
}
