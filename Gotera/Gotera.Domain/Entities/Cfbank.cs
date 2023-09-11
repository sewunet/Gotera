using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Cfbank
{
    public int Id { get; set; }

    public string AccountNo { get; set; }

    public string GlAccount { get; set; }

    public string BankName { get; set; }

    public string Location { get; set; }

    public string ContactAddress { get; set; }

    public decimal? BeginingBalance { get; set; }

    public string Status { get; set; }

    public int? Ref { get; set; }

    public int? BalDate { get; set; }

    public int? UserId { get; set; }

    public DateTime? Createddate { get; set; }

    public string Createdby { get; set; }

    public bool? Isreviewed { get; set; }

    public DateTime? Revieweddate { get; set; }

    public string Reviewedby { get; set; }

    public bool? Isapproved { get; set; }

    public string Approvedby { get; set; }

    public string Updatedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public bool? Isdeleted { get; set; }

    public bool? Isactive { get; set; }

    public bool? AllowNegativeBalance { get; set; }

    public bool? Isdefaultbank { get; set; }

    public bool? Ispettycashier { get; set; }

    public char? Trial317 { get; set; }
}
