using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Engstoretran
{
    public int Stid { get; set; }

    public int? Reqid { get; set; }

    public int? Trdate { get; set; }

    public string GrnsivNo { get; set; }

    public int? StoreId { get; set; }

    public string RcvdFrom { get; set; }

    public string RcvdBy { get; set; }

    public int? Itemid { get; set; }

    public int? Catid { get; set; }

    public string ItemDesc { get; set; }

    public string Uom { get; set; }

    public decimal? Qtyrcvd { get; set; }

    public decimal? Qtyiss { get; set; }

    public decimal? Unitprice { get; set; }

    public bool? VatExcl { get; set; }

    public string Supplier { get; set; }

    public string RecType { get; set; }

    public string MtvNo { get; set; }

    public int? Checked { get; set; }

    public int? Project { get; set; }

    public string PlateNo { get; set; }

    public int? Subcontractor { get; set; }

    public int? UserId { get; set; }

    public int? AppUser { get; set; }

    public int? AppDate { get; set; }

    public string Remark { get; set; }

    public string SivGrn { get; set; }

    public char? Trial407 { get; set; }
}
