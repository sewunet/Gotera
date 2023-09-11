using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblcompany
{
    public int Id { get; set; }

    public string Companyname { get; set; }

    public byte[] Companylogo { get; set; }

    public string Companymoto { get; set; }

    public char? Trial675 { get; set; }
}
