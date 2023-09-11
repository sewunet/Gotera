using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Serviceagreement
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public decimal? Uptophaseone { get; set; }

    public decimal? Abovephaseone { get; set; }

    public decimal? Phaseone { get; set; }

    public decimal? Currentadvanceamount { get; set; }

    public decimal? Outstandingadvanceamount { get; set; }

    public string Startdate { get; set; }

    public string Enddate { get; set; }

    public decimal? Agreementsize { get; set; }

    public bool? Isactive { get; set; }

    public string Reason { get; set; }

    public string Agreementnumber { get; set; }

    public bool? Isdeleted { get; set; }

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

    public int? Serviceproviderid { get; set; }

    public int? Managerid { get; set; }

    public int? Servicerecieverid { get; set; }

    public int? ErpScid { get; set; }

    public string ErpScname { get; set; }

    public int? ErpDate { get; set; }

    public int? StartDate1 { get; set; }

    public int? EndDate1 { get; set; }

    public bool? Hasattachement { get; set; }

    public char? Trial567 { get; set; }

    public virtual Manager Manager { get; set; }
}
