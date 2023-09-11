using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Dcfile
{
    public int Id { get; set; }

    public int? Docid { get; set; }

    public string Filename { get; set; }

    public string Contenttype { get; set; }

    public byte[] Data { get; set; }

    public int? Doctype { get; set; }

    public char? Trial346 { get; set; }
}
