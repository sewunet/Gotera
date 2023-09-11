using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Dcsubdoctype
{
    public int Id { get; set; }

    public int? Docid { get; set; }

    public string Subdoc { get; set; }

    public char? Trial230 { get; set; }
}
