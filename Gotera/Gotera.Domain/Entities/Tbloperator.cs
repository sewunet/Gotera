using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tbloperator
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Tele { get; set; }

    public string Employer { get; set; }

    public string Status { get; set; }

    public string Remark { get; set; }

    public char? Trial841 { get; set; }
}
