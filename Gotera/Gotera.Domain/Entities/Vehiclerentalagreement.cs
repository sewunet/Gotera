using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Vehiclerentalagreement
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Reason { get; set; }

    public int? Odometerreading { get; set; }

    public decimal? Currentadvanceamount { get; set; }

    public decimal? Outstandingadvanceamount { get; set; }

    public string Startdate { get; set; }

    public string Enddate { get; set; }

    public int? Contractedhours { get; set; }

    public decimal? Hourlyrate { get; set; }

    public bool? Isdeleted { get; set; }

    public bool? Isactive { get; set; }

    public bool? Isincomegenerating { get; set; }

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

    public int? Projectid { get; set; }

    public int? Vehicleid { get; set; }

    public int? Managerid { get; set; }

    public int? Ownerid { get; set; }

    public int? Renterid { get; set; }

    public int? Rentingid { get; set; }

    public int? Creatoruserid { get; set; }

    public string PlateNo { get; set; }

    public int? ErpDate { get; set; }

    public int? StartDate1 { get; set; }

    public int? EndDate1 { get; set; }

    public bool? Hasattachement { get; set; }

    public int? AppLevel { get; set; }

    public bool? IsvatRegistered { get; set; }

    public string ReferenceNo { get; set; }

    public char? Trial962 { get; set; }

    public virtual Manager Manager { get; set; }

    public virtual Tblvendor Owner { get; set; }

    public virtual Tblproject Project { get; set; }
}
