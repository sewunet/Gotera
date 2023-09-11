using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Dcsendto
{
    public int Id { get; set; }

    public int? DocId { get; set; }

    public int? UserId { get; set; }

    public string Comment { get; set; }

    public int? Sendto { get; set; }

    public int? Status { get; set; }

    public char? Trial224 { get; set; }
}
