using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class OwnerAgreement
{
    public double? Id { get; set; }

    public string Name { get; set; }

    public double? Projectid { get; set; }

    public double? Vehicleid { get; set; }

    public double? Managerid { get; set; }

    public double? Ownerid { get; set; }

    public double? Renterid { get; set; }

    public char? Trial505 { get; set; }
}
