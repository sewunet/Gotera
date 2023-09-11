using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Materialoutputactivity
{
    public int Id { get; set; }

    public string SivNo { get; set; }

    public string GrnNo { get; set; }

    public int? Itemid { get; set; }

    public string Itemdescription { get; set; }

    public string Uom { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Unitprice { get; set; }

    public string Dispenseddate { get; set; }

    public string Platenumber { get; set; }

    public bool? Isdeleted { get; set; }

    public string Reason { get; set; }

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

    public string Projectname { get; set; }

    public int? Clientid { get; set; }

    public string Clientname { get; set; }

    public string Receivername { get; set; }

    public int? Erpdate { get; set; }

    public int? Period { get; set; }

    public int? Userid { get; set; }

    public int? ScId { get; set; }

    public int? Status { get; set; }

    public bool? Isactive { get; set; }

    public char? Trial495 { get; set; }
}
