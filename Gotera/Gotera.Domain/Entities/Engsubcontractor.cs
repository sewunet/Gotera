using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Engsubcontractor
{
    public int Scid { get; set; }

    public string ScName { get; set; }

    public int? Project { get; set; }

    public int? SubCategory { get; set; }

    public string Isstore { get; set; }

    public string Issc { get; set; }

    public char? Trial407 { get; set; }
}
