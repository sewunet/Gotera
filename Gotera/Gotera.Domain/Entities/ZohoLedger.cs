using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class ZohoLedger
{
    public double? ZohoId { get; set; }

    public string TrDate { get; set; }

    public string Pv { get; set; }

    public string Checkno { get; set; }

    public DateTime? Date { get; set; }

    public string AccountGroup { get; set; }

    public string AccountType { get; set; }

    public string AccountName { get; set; }

    public string Account { get; set; }

    public string TransactionDetails { get; set; }

    public double? TransactionId { get; set; }

    public string OffsetAccountId { get; set; }

    public string OffsetAccountType { get; set; }

    public string TransactionType { get; set; }

    public string ReferenceNumber { get; set; }

    public string EntityNumber { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public double? NetAmount { get; set; }

    public double? FcyDebit { get; set; }

    public double? FcyCredit { get; set; }

    public double? FcyNetAmount { get; set; }

    public double? ContactId { get; set; }

    public string ContactName { get; set; }

    public double? AccountId { get; set; }

    public string Description { get; set; }

    public string CurrencyCode { get; set; }

    public double? AccountCode { get; set; }

    public string AccountCfOldACNo { get; set; }

    public double? ErpId { get; set; }

    public double? QbId { get; set; }

    public char? Trial972 { get; set; }
}
