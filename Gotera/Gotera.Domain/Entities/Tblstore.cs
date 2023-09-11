using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblstore
{
    public int Id { get; set; }

    public string StoreName { get; set; }

    public string StoreTelephone { get; set; }

    public string StoreLocation { get; set; }

    public int? Project { get; set; }

    public string Projectname { get; set; }

    public string Createddate { get; set; }

    public string Createdby { get; set; }

    public char? Trial906 { get; set; }
}
