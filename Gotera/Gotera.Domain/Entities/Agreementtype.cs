using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Agreementtype
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public bool Isactive { get; set; }

    public char? Trial268 { get; set; }
}
