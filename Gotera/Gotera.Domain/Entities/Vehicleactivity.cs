using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Vehicleactivity
{
    public int Id { get; set; }

    public decimal Fueltaken { get; set; }

    public string Fueltype { get; set; }

    public decimal Fuelprice { get; set; }

    public int Odometerreading { get; set; }

    public string Operators { get; set; }

    public string Reportedby { get; set; }

    public bool Isdeleted { get; set; }

    public string Reason { get; set; }

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

    public int Vehicleid { get; set; }

    public int Managerid { get; set; }

    public int Usedbyid { get; set; }

    public decimal Workinghours { get; set; }

    public decimal Idlehours { get; set; }

    public decimal Downhours { get; set; }

    public string Idlereason { get; set; }

    public string Workingdate { get; set; }

    public decimal Hourlyrate { get; set; }

    public int Projectid { get; set; }

    public string Projectname { get; set; }

    public int Siteid { get; set; }

    public string Sitename { get; set; }

    public string Platenumber { get; set; }

    public int Agreementid { get; set; }

    public string Agreementname { get; set; }

    public string Managername { get; set; }

    public string Usedbyname { get; set; }

    public decimal Unpaididlehours { get; set; }

    public char? Trial959 { get; set; }
}
