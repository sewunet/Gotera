using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tbltsjournalsetup
{
    public int Id { get; set; }

    public string GlWorkedamountDr { get; set; }

    public string GlWorkedamountDrDesc { get; set; }

    public string GlVatDr { get; set; }

    public string GlVatDrDesc { get; set; }

    public string GlWhtCr { get; set; }

    public string GlWhtCrDesc { get; set; }

    public string GlNetpayableCr { get; set; }

    public string GlNetpayableCrDesc { get; set; }

    public string Updatedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public char? Trial910 { get; set; }
}
