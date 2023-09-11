using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Cpstation
{
    public int Id { get; set; }

    public int? Projectid { get; set; }

    public string Projectname { get; set; }

    public string Stationdescription { get; set; }

    public bool? Isactive { get; set; }

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

    public char? Trial337 { get; set; }
}
