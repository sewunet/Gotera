using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Capitalagreement
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public bool? Isactive { get; set; }

    public string Reason { get; set; }

    public bool Isdeleted { get; set; }

    public string Agreementdate { get; set; }

    public decimal Shareprecent { get; set; }

    public decimal Sharemoneyvalue { get; set; }

    public decimal Paidamount { get; set; }

    public decimal Unpaidamount { get; set; }

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

    public int Projectid { get; set; }

    public int Shareholderid { get; set; }

    public int Managerid { get; set; }

    public char? Trial314 { get; set; }

    public virtual Manager Manager { get; set; }

    public virtual Tblproject Project { get; set; }

    public virtual Tblvendor Shareholder { get; set; }
}
