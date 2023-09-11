using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblaccesspm
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public string Username { get; set; }

    public bool? Grn { get; set; }

    public bool? Grnreview { get; set; }

    public bool? Grnapproval { get; set; }

    public bool? Siv { get; set; }

    public bool? Sivreview { get; set; }

    public bool? Sivapproval { get; set; }

    public bool? Projectpurchase { get; set; }

    public bool? Sivupdate { get; set; }

    public bool? Pmreports { get; set; }

    public string Createdby { get; set; }

    public string Createddate { get; set; }

    public string Updatedby { get; set; }

    public string Updateddate { get; set; }

    public bool? Attachgrn { get; set; }

    public bool? Attachsiv { get; set; }

    public bool? Physicalcountsheet { get; set; }

    public bool? Physicalcountentered { get; set; }

    public bool? Stockitemreconciliation { get; set; }

    public bool? Inventoryadjustment { get; set; }

    public bool? Materialreturn { get; set; }

    public bool? Materialreturnapp { get; set; }

    public char? Trial596 { get; set; }
}
