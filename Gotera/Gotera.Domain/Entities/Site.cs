using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Site
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Location { get; set; }

    public bool? Isactive { get; set; }

    public string Reason { get; set; }

    public string Sitenumber { get; set; }

    public bool Ismainsite { get; set; }

    public bool Hasinternet { get; set; }

    public bool Haspower { get; set; }

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

    public int Projectid { get; set; }

    public char? Trial570 { get; set; }

    public virtual Tblproject Project { get; set; }
}
