using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblaccessplanning
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public string Username { get; set; }

    public bool? Unitofmeasure { get; set; }

    public bool? Billgroup { get; set; }

    public bool? Payitems { get; set; }

    public bool? Projectplan { get; set; }

    public bool? Projectbudget { get; set; }

    public bool? Projectexecution { get; set; }

    public bool? Planningreports { get; set; }

    public string Createdby { get; set; }

    public string Createddate { get; set; }

    public string Updatedby { get; set; }

    public string Updateddate { get; set; }

    public char? Trial596 { get; set; }
}
