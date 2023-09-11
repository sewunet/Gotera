using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Vehicletransportactivity
{
    public int Id { get; set; }

    public string Description { get; set; }

    public decimal Unloadedamount { get; set; }

    public decimal Fueltaken { get; set; }

    public string Fueltype { get; set; }

    public decimal Fuelprice { get; set; }

    public int Odometerreading { get; set; }

    public string Workstartdate { get; set; }

    public string Workenddate { get; set; }

    public string Operators { get; set; }

    public decimal Withholding { get; set; }

    public decimal Vat { get; set; }

    public string Reportedby { get; set; }

    public bool Isdeleted { get; set; }

    public string Reason { get; set; }

    public int Projectid { get; set; }

    public string Projectname { get; set; }

    public int Vehicleid { get; set; }

    public string Platenumber { get; set; }

    public int Usedbyid { get; set; }

    public string Usedbyname { get; set; }

    public int Agreementid { get; set; }

    public string Agreementname { get; set; }

    public int Managerid { get; set; }

    public string Managername { get; set; }

    public int Transporterid { get; set; }

    public string Transportername { get; set; }

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

    public int Ownerid { get; set; }

    public string Ownername { get; set; }

    public char? Trial965 { get; set; }
}
