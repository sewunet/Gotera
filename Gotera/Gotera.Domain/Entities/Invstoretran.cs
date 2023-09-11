using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Invstoretran
{
    public int RecId { get; set; }

    public string RecType { get; set; }

    public string Trdate { get; set; }

    public string Reference { get; set; }

    public int? StoreId { get; set; }

    public int? ItemId { get; set; }

    public decimal? QtyGrn { get; set; }

    public decimal? QtyIss { get; set; }

    public decimal? QtyIst { get; set; }

    public decimal? QtyRet { get; set; }

    public decimal? Unitprice { get; set; }

    public int? Supplier { get; set; }

    public string Issuedto { get; set; }

    public int? Dept { get; set; }

    public int? Project { get; set; }

    public string Receivedfrom { get; set; }

    public int? Purchaser { get; set; }

    public string Condition { get; set; }

    public string Remark { get; set; }

    public int? ViewState { get; set; }

    public int? QuotationId { get; set; }

    public char? Trial459 { get; set; }
}
