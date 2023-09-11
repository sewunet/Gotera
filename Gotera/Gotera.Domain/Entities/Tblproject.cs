using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblproject
{
    public int ProjId { get; set; }

    public string Descr { get; set; }

    public string Jobid { get; set; }

    public string Location { get; set; }

    public int? Pmanager { get; set; }

    public string Remarks { get; set; }

    public string Status { get; set; }

    public decimal? ContractAmount { get; set; }

    public int? StartDate { get; set; }

    public int? EstEndDate { get; set; }

    public int? Owner { get; set; }

    public string Reason { get; set; }

    public bool? Isdeleted { get; set; }

    public DateTime? Createddate { get; set; }

    public string Createdby { get; set; }

    public bool? Isreviewed { get; set; }

    public DateTime? Revieweddate { get; set; }

    public string Reviewedby { get; set; }

    public bool? Isapproved { get; set; }

    public DateTime? Approveddate { get; set; }

    public string Approvedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public string Updatedby { get; set; }

    public string Ownername { get; set; }

    public bool? Isactive { get; set; }

    public int? Userid { get; set; }

    public char? Trial874 { get; set; }

    public virtual ICollection<Capitalagreement> Capitalagreements { get; set; } = new List<Capitalagreement>();

    public virtual ICollection<Machineryrentalagreement> Machineryrentalagreements { get; set; } = new List<Machineryrentalagreement>();

    public virtual ICollection<Salesagreement> Salesagreements { get; set; } = new List<Salesagreement>();

    public virtual ICollection<Site> Sites { get; set; } = new List<Site>();

    public virtual ICollection<Vehiclerentalagreement> Vehiclerentalagreements { get; set; } = new List<Vehiclerentalagreement>();

    public virtual ICollection<Vehicletransportagreement> Vehicletransportagreements { get; set; } = new List<Vehicletransportagreement>();
}
