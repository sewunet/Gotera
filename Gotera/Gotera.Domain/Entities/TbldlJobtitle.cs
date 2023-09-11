using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class TbldlJobtitle
{
    public int Id { get; set; }

    public string JobTitle { get; set; }

    public char? Trial730 { get; set; }
}
