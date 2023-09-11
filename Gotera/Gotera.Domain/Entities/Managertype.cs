using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Managertype
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public bool? Isactive { get; set; }

    public string Reason { get; set; }

    public bool Isdeleted { get; set; }

    public DateTime Createddate { get; set; }

    public string Createdby { get; set; }

    public bool Isreviewed { get; set; }

    public DateTime? Revieweddate { get; set; }

    public string Reviewedby { get; set; }

    public bool Isapproved { get; set; }

    public DateTime? Approveddate { get; set; }

    public string Approvedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public string Updatedby { get; set; }

    public char? Trial492 { get; set; }

    public virtual ICollection<Manager> Managers { get; set; } = new List<Manager>();
}
