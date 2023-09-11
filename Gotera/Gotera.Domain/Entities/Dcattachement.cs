using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Dcattachement
{
    public int Id { get; set; }

    public int? DocId { get; set; }

    public string FileName { get; set; }

    public int? DocType { get; set; }

    public char? Trial337 { get; set; }
}
