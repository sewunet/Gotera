using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblaccessinventory
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public string Username { get; set; }

    public bool? ItemMaster { get; set; }

    public bool? PhysicalCount { get; set; }

    public bool? StoreRequisition { get; set; }

    public int? SrApproval { get; set; }

    public bool? Store { get; set; }

    public bool? PurchaseRequisition { get; set; }

    public bool? Quotation { get; set; }

    public bool? QuotationApproval { get; set; }

    public int? Priceapproval { get; set; }

    public int? Prapproval { get; set; }

    public bool? Po { get; set; }

    public bool? PoApproval { get; set; }

    public bool? FinanaceRequest { get; set; }

    public bool? GrnHo { get; set; }

    public bool? GrnProject { get; set; }

    public bool? Siv { get; set; }

    public bool? Mtv { get; set; }

    public bool? Srv { get; set; }

    public bool? SrvApp { get; set; }

    public bool? InvenroryReports { get; set; }

    public string Createdby { get; set; }

    public string Createddate { get; set; }

    public string Updatedby { get; set; }

    public string Updateddate { get; set; }

    public char? Trial593 { get; set; }
}
