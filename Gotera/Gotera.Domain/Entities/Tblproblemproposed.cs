using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblproblemproposed
{
    public int Id { get; set; }

    public int? QuotationId { get; set; }

    public int? ProblemId { get; set; }

    public char? Trial874 { get; set; }
}
