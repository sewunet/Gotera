using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblgrn
{
    public int GrnId { get; set; }

    public DateTime? Grndate { get; set; }

    public string GrnNo { get; set; }

    public int? StoreId { get; set; }

    public string Refno { get; set; }

    public int? Itemid { get; set; }

    public decimal? Qtyrcvd { get; set; }

    public decimal? Unitprice { get; set; }

    public int? RcvdBy { get; set; }

    public string Userid { get; set; }

    public int? RcvdFrom { get; set; }

    public string RecType { get; set; }

    public int? CondId { get; set; }

    public string Remark { get; set; }

    public int? ViewState { get; set; }

    public int? QuotationId { get; set; }

    public string Eqtype { get; set; }

    public string PlateNo { get; set; }

    public string Driver { get; set; }

    public string IssuedBy { get; set; }

    public string ItemReceivedby { get; set; }

    public int? RcvStore { get; set; }

    public string License { get; set; }

    public string Address { get; set; }

    public string PayableAt { get; set; }

    public int? Project { get; set; }

    public int? GrnDate1 { get; set; }

    public decimal? RcvUnitprice { get; set; }

    public decimal? IssUnitprice { get; set; }

    public bool? Isdeleted { get; set; }

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

    public int? Managerid { get; set; }

    public bool? Isusedrecord { get; set; }

    public int? Purchaserid { get; set; }

    public string Purchasername { get; set; }

    public string MUnit { get; set; }

    public string ConvertedUom { get; set; }

    public decimal? ConvertedQty { get; set; }

    public decimal? ConversionFactor { get; set; }

    public decimal? ConvertedUnitprice { get; set; }

    public decimal? CommStockUomQty { get; set; }

    public bool? Iscreditpurchase { get; set; }

    public string SivMtvNo { get; set; }

    public string OldGrnColumnValue { get; set; }

    public char? Trial792 { get; set; }
}
