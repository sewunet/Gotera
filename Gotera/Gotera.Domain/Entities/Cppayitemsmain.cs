using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Cppayitemsmain
{
    public int Id { get; set; }

    public string Billgroupid { get; set; }

    public string Payitem { get; set; }

    public string Payitemdescription { get; set; }

    public bool? Isheading { get; set; }

    public int? Projectid { get; set; }

    public string Projectname { get; set; }

    public decimal? Contractquantity { get; set; }

    public decimal? Adjustedquantity { get; set; }

    public string Uom { get; set; }

    public decimal? Unitrate { get; set; }

    public decimal? Unitrateadjusted { get; set; }

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

    public bool? Issiteoperation { get; set; }

    public char? Trial330 { get; set; }
}
