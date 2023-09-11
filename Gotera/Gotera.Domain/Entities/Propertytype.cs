using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Propertytype
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public char? Trial521 { get; set; }

    public virtual ICollection<Salesagreement> Salesagreements { get; set; } = new List<Salesagreement>();
}
