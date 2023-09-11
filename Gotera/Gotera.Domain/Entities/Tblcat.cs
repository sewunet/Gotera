using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblcat
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int? SortOrder { get; set; }

    public int? ScItems { get; set; }

    public char? Trial658 { get; set; }
}
