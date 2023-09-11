using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tbloutsource
{
    public int JobId { get; set; }

    public string EqId { get; set; }

    public int? ToCompany { get; set; }

    public decimal? Fee { get; set; }

    public string CompletionDate { get; set; }

    public string Reference { get; set; }

    public string Status { get; set; }

    public string Userid { get; set; }

    public char? Trial841 { get; set; }
}
