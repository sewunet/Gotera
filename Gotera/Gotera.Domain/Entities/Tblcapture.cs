using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblcapture
{
    public int Id { get; set; }

    public DateTime? Docdate { get; set; }

    public string Docref { get; set; }

    public string Docauthor { get; set; }

    public string Docsubject { get; set; }

    public string Doclang { get; set; }

    public int? Docpages { get; set; }

    public DateTime? Docrcvdate { get; set; }

    public string Doccategory { get; set; }

    public string Docurl { get; set; }

    public bool? Docatt { get; set; }

    public string Macroref { get; set; }

    public int? Doctype { get; set; }

    public DateTime? Time { get; set; }

    public char? Trial655 { get; set; }
}
