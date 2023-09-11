using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblchart2012
{
    public string GlAccount { get; set; }

    public string GlDescription { get; set; }

    public int? AccountTypeId { get; set; }

    public string AccountType { get; set; }

    public int? SubtypeId { get; set; }

    public string AccountSubtype { get; set; }

    public string Description { get; set; }

    public int? Userid { get; set; }

    public string Username { get; set; }

    public DateTime? Createddate { get; set; }

    public bool? Isreviewed { get; set; }

    public string Reviewedby { get; set; }

    public DateTime? Revieweddate { get; set; }

    public bool? Isapproved { get; set; }

    public string Approvedby { get; set; }

    public DateTime? Approveddate { get; set; }

    public string Updatedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public bool? Isactive { get; set; }

    public string OldAccountNo { get; set; }

    public string OldAccountName { get; set; }

    public bool? BankallowNegativebalance { get; set; }

    public bool? IsvatAccount { get; set; }

    public bool? IswhtAccount { get; set; }

    public string Category { get; set; }

    public char? Trial665 { get; set; }
}
