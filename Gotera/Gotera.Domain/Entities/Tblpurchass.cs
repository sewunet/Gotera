using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblpurchass
{
    public int Id { get; set; }

    public int? PrdId { get; set; }

    public int? Purchasorid { get; set; }

    public int? Prassstatid { get; set; }

    public DateTime? Prassstatdate { get; set; }

    public bool? Processed { get; set; }

    public char? Trial874 { get; set; }
}
