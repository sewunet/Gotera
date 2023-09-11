using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblpayrolljournalsetup
{
    public int Id { get; set; }

    public string GlAccount { get; set; }

    public string GlDescription { get; set; }

    public string ItemName { get; set; }

    public bool? IsdebitValue { get; set; }

    public bool? Issummary { get; set; }

    public string Remark { get; set; }

    public string Updatedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public char? Trial848 { get; set; }
}
