using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Engstatus
{
    public int Id { get; set; }

    public string StatusDesc { get; set; }

    public char? Trial403 { get; set; }
}
