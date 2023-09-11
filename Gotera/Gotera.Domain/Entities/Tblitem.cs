using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblitem
{
    public int Id { get; set; }

    public string ItemName { get; set; }

    public string ItemCode { get; set; }

    public string ItemDesc { get; set; }

    public int? CatId { get; set; }

    public int? SubCatId { get; set; }

    public string ItemTypeId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string Createdby { get; set; }

    public string Updatedby { get; set; }

    public string Updateddate { get; set; }

    public string MUnit { get; set; }

    public string ConvertedUom { get; set; }

    public decimal? ConvertedQty { get; set; }

    public int? MinStockLevel { get; set; }

    public string GlInventoryAcc { get; set; }

    public string GlSaleAcc { get; set; }

    public string GlSaleCostAcc { get; set; }

    public string Active { get; set; }

    public decimal? Avecost { get; set; }

    public decimal? OpeningBalance { get; set; }

    public decimal? Unitprice { get; set; }

    public string OpeningCondition { get; set; }

    public DateTime? OpeningDate { get; set; }

    public int? StoreId { get; set; }

    public char? Trial818 { get; set; }
}
