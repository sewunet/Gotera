using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblcheckregistry
{
    public int Id { get; set; }

    public int? Bankid { get; set; }

    public string Bankname { get; set; }

    public string Checknumber { get; set; }

    public string Remark { get; set; }

    public bool? Isused { get; set; }

    public bool? Isapproved { get; set; }

    public string Createddate { get; set; }

    public string Createdby { get; set; }

    public string Updateddate { get; set; }

    public string Updatedby { get; set; }

    public string GlAccount { get; set; }

    public string QbGlAccount { get; set; }

    public string QbGlDescription { get; set; }

    public char? Trial668 { get; set; }
}
