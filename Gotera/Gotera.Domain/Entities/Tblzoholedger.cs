using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblzoholedger
{
    public double? ZohoId { get; set; }

    public double? TrDate { get; set; }

    public string Pv { get; set; }

    public string Checkno { get; set; }

    public DateTime? Date { get; set; }

    public string AccountGroup { get; set; }

    public string AccountType { get; set; }

    public string AccountName { get; set; }

    public string Account { get; set; }

    public string TransactionDetails { get; set; }

    public string TransactionId { get; set; }

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

    public string ErpId { get; set; }

    public string QbId { get; set; }

    public char? Trial923 { get; set; }
}
