using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Aspnetuserrole
{
    public string Userid { get; set; }

    public string Roleid { get; set; }

    public char? Trial271 { get; set; }

    public virtual Aspnetrole Role { get; set; }

    public virtual Aspnetuser User { get; set; }
}
