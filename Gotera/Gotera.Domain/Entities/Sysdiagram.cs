using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Sysdiagram
{
    public string Name { get; set; }

    public int PrincipalId { get; set; }

    public int DiagramId { get; set; }

    public int? Version { get; set; }

    public byte[] Definition { get; set; }

    public char? Trial573 { get; set; }
}
