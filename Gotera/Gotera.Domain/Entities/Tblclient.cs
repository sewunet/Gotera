using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblclient
{
    public int Id { get; set; }

    public string ClientName { get; set; }

    public string Address { get; set; }

    public char? Trial671 { get; set; }
}
