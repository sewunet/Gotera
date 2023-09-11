using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tbldoccomment
{
    public int Id { get; set; }

    public int? Refdocid { get; set; }

    public int? Commentby { get; set; }

    public string Comment { get; set; }

    public DateTime? Commentdate { get; set; }

    public char? Trial779 { get; set; }
}
