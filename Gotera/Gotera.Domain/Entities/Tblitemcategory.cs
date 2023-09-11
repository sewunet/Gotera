using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblitemcategory
{
    public int Id { get; set; }

    public string CatName { get; set; }

    public int? SortOrder { get; set; }

    public int? ScItems { get; set; }

    public bool? Isinventoryitem { get; set; }

    public char? Trial828 { get; set; }
}
