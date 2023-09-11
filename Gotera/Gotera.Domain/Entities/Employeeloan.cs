using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Employeeloan
{
    public int Id { get; set; }

    public decimal Loanamount { get; set; }

    public decimal Precentdeduction { get; set; }

    public string Reason { get; set; }

    public bool Isdeleted { get; set; }

    public DateTime Createddate { get; set; }

    public string Createdby { get; set; }

    public bool Isreviewed { get; set; }

    public DateTime? Revieweddate { get; set; }

    public string Reviewedby { get; set; }

    public bool Isapproved { get; set; }

    public DateTime? Approveddate { get; set; }

    public string Approvedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public string Updatedby { get; set; }

    public int Employeeid { get; set; }

    public string Startdate { get; set; }

    public string Enddate { get; set; }

    public decimal Outstandingloanamount { get; set; }

    public bool Isactive { get; set; }

    public int Clientid { get; set; }

    public char? Trial237 { get; set; }
}
