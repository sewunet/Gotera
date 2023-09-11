using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblcatsub
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int? CatId { get; set; }

    public int? ProjectId { get; set; }

    public char? Trial658 { get; set; }
}
