using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Cfsubcategory
{
    public int Sid { get; set; }

    public int? Cid { get; set; }

    public string SubcatName { get; set; }

    public char? Trial320 { get; set; }
}
