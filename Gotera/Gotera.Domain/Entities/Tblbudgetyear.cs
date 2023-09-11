using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblbudgetyear
{
    public int Id { get; set; }

    public int Budgetyear { get; set; }

    public int StartDate { get; set; }

    public int EndDate { get; set; }

    public bool Isactive { get; set; }

    public char? Trial655 { get; set; }
}
