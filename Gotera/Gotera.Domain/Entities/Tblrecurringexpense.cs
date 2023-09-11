using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblrecurringexpense
{
    public int Id { get; set; }

    public string ProfileName { get; set; }

    public int? StartDate { get; set; }

    public int? Vendorid { get; set; }

    public string Vendorname { get; set; }

    public int? Itemid { get; set; }

    public string Itemname { get; set; }

    public string RepeateEvery { get; set; }

    public decimal? Amount { get; set; }

    public string Createddate { get; set; }

    public bool? Isterminated { get; set; }

    public string Memo { get; set; }

    public bool? Isapproved { get; set; }

    public string Approvedby { get; set; }

    public DateTime? Approveddate { get; set; }

    public string Mode { get; set; }

    public int? RepeateCount { get; set; }

    public char? Trial897 { get; set; }
}
