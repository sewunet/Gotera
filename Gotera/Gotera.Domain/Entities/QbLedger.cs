using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class QbLedger
{
    public double? QbId { get; set; }

    public double? TrDate { get; set; }

    public DateTime? Transationdate { get; set; }

    public string Pv { get; set; }

    public string Checkno { get; set; }

    public DateTime? Date { get; set; }

    public string TransactionType { get; set; }

    public string No { get; set; }

    public string Name { get; set; }

    public string MemoDescription { get; set; }

    public string Split { get; set; }

    public double? Amount { get; set; }

    public double? Balance { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string LastModifiedBy { get; set; }

    public string Customer { get; set; }

    public string Supplier { get; set; }

    public string Employee { get; set; }

    public string Location { get; set; }

    public string Class { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public string AccountNo { get; set; }

    public string Account { get; set; }

    public double? ErpId { get; set; }

    public double? ZohoId { get; set; }

    public char? Trial528 { get; set; }
}
