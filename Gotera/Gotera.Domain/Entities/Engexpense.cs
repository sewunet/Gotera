using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Engexpense
{
    public int Id { get; set; }

    public int? Reqid { get; set; }

    public int? MtvDate { get; set; }

    public int? Period { get; set; }

    public int? Itemid { get; set; }

    public int? MtvNo { get; set; }

    public int? GrnNo { get; set; }

    public int? ProjectId { get; set; }

    public decimal? Qty { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? ApprovedAmount { get; set; }

    public int? UserId { get; set; }

    public string PlateNo { get; set; }

    public string Checked { get; set; }

    public string RecordType { get; set; }

    public string Remark { get; set; }

    public string RecStatus { get; set; }

    public string PvNo { get; set; }

    public int? PvEnteredby { get; set; }

    public string PrintRec { get; set; }

    public string Paid { get; set; }

    public string Cash { get; set; }

    public int? Subcontractor { get; set; }

    public int? Ref { get; set; }

    public string TranValid { get; set; }

    public int? PayTo { get; set; }

    public string PvChecked { get; set; }

    public bool? Issendtobill { get; set; }

    public string BudCheckedby { get; set; }

    public string BudApprovedby { get; set; }

    public bool? Ispayrolltran { get; set; }

    public bool? Iscreditpayment { get; set; }

    public bool? Isprojecttran { get; set; }

    public char? Trial332 { get; set; }
}
