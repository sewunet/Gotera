using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class GlForvendorreport
{
    public int Id { get; set; }

    public string GlAccount { get; set; }

    public string GlDescription { get; set; }

    public string Accounttype { get; set; }

    public char? Trial436 { get; set; }
}
