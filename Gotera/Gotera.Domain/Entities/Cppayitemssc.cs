using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Cppayitemssc
{
    public int Id { get; set; }

    public int? Projectid { get; set; }

    public string Projectname { get; set; }

    public int? Subcontractor { get; set; }

    public string ScName { get; set; }

    public string Agreementname { get; set; }

    public string Billgroupid { get; set; }

    public string Payitemsc { get; set; }

    public string Payitemdescription { get; set; }

    public string Payitemmain { get; set; }

    public bool? Isheading { get; set; }

    public decimal Contractquantity { get; set; }

    public decimal? Adjustedquantity { get; set; }

    public string Uom { get; set; }

    public decimal? Unitrate { get; set; }

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

    public char? Trial333 { get; set; }
}
