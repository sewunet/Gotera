using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblvendor
{
    public int Vid { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public string Tel { get; set; }

    public string Tin { get; set; }

    public string Vat { get; set; }

    public string Rate { get; set; }

    public string ContactPerson { get; set; }

    public bool? Isactive { get; set; }

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

    public bool? Isinternal { get; set; }

    public bool? Isvendor { get; set; }

    public bool? Iscustomer { get; set; }

    public bool? VRenter { get; set; }

    public bool? VEmployee { get; set; }

    public bool? VSubcontractor { get; set; }

    public bool? VSupplier { get; set; }

    public bool? VPurchaser { get; set; }

    public bool? VTransporter { get; set; }

    public bool? VOthers { get; set; }

    public bool? CRealestate { get; set; }

    public bool? CEmployer { get; set; }

    public bool? COthers { get; set; }

    public char? Trial913 { get; set; }

    public virtual ICollection<Capitalagreement> Capitalagreements { get; set; } = new List<Capitalagreement>();

    public virtual ICollection<Salesagreement> Salesagreements { get; set; } = new List<Salesagreement>();

    public virtual ICollection<Vehiclerentalagreement> Vehiclerentalagreements { get; set; } = new List<Vehiclerentalagreement>();

    public virtual ICollection<Vehicletransportagreement> Vehicletransportagreements { get; set; } = new List<Vehicletransportagreement>();
}
