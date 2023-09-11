using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblitemrequestdetail
{
    public int ItemRequestDetailId { get; set; }

    public int? ItemId { get; set; }

    public string ItemTag { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? ApprovedQuantity { get; set; }

    public DateTime? ExpectedDate { get; set; }

    public int? RequestStatusId { get; set; }

    public DateTime? StatusDate { get; set; }

    public int? ItemRequestId { get; set; }

    public string Remarks { get; set; }

    public decimal? T1appqty { get; set; }

    public int? Tier1appid { get; set; }

    public DateTime? Tier1appdate { get; set; }

    public decimal? T2appqty { get; set; }

    public int? Tier2appid { get; set; }

    public DateTime? Tier2appdate { get; set; }

    public int? Tier3appid { get; set; }

    public DateTime? Tier3appdate { get; set; }

    public decimal? T3appqty { get; set; }

    public char? Trial835 { get; set; }
}
