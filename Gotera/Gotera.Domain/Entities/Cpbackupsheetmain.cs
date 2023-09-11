using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Cpbackupsheetmain
{
    public int Id { get; set; }

    public int? Projectid { get; set; }

    public string Projectname { get; set; }

    public string Billgroupid { get; set; }

    public string Payitem { get; set; }

    public string Payitemdescr { get; set; }

    public string Stationname { get; set; }

    public decimal? Executedqty { get; set; }

    public int? Periodstart { get; set; }

    public int? Periodend { get; set; }

    public int? Period { get; set; }

    public string Ipcno { get; set; }

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

    public string Remark { get; set; }

    public string Uom { get; set; }

    public decimal? Unitrate { get; set; }

    public decimal? Executedamount { get; set; }

    public double? StationStart { get; set; }

    public double? StationEnd { get; set; }

    public char? Trial320 { get; set; }
}
