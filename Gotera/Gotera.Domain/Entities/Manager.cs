using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Manager
{
    public int Id { get; set; }

    public string Firstname { get; set; }

    public string Middlename { get; set; }

    public string Lastname { get; set; }

    public string Employeeid { get; set; }

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

    public int Managertypeid { get; set; }

    public char? Trial488 { get; set; }

    public virtual ICollection<Capitalagreement> Capitalagreements { get; set; } = new List<Capitalagreement>();

    public virtual ICollection<Machineryrentalagreement> Machineryrentalagreements { get; set; } = new List<Machineryrentalagreement>();

    public virtual Managertype Managertype { get; set; }

    public virtual ICollection<Salesagreement> Salesagreements { get; set; } = new List<Salesagreement>();

    public virtual ICollection<Serviceagreement> Serviceagreements { get; set; } = new List<Serviceagreement>();

    public virtual ICollection<Vehiclerentalagreement> Vehiclerentalagreements { get; set; } = new List<Vehiclerentalagreement>();

    public virtual ICollection<Vehicletransportagreement> Vehicletransportagreements { get; set; } = new List<Vehicletransportagreement>();
}
