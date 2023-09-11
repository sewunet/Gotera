using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Aspnetrole
{
    public string Id { get; set; }

    public string Description { get; set; }

    public string Name { get; set; }

    public string Code { get; set; }

    public char? Trial271 { get; set; }

    public virtual ICollection<Aspnetuserrole> Aspnetuserroles { get; set; } = new List<Aspnetuserrole>();
}
