using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Dccontact
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public char? Trial340 { get; set; }
}
