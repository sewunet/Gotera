using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Zoholedger1
{
    public int? Id { get; set; }

    public string Date { get; set; }

    public string AccountGroup { get; set; }

    public string AccountType { get; set; }

    public string AccountName { get; set; }

    public string TransactionDetails { get; set; }

    public string TransactionId { get; set; }

    public string ReferenceTransactionId { get; set; }

    public string OffsetAccountId { get; set; }

    public string OffsetAccountType { get; set; }

    public string TransactionType { get; set; }

    public string ReferenceNumber { get; set; }

    public string EntityNumber { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public decimal? NetAmount { get; set; }

    public decimal? FcyDebit { get; set; }

    public decimal? FcyCredit { get; set; }

    public decimal? FcyNetAmount { get; set; }

    public string ContactId { get; set; }

    public string ContactName { get; set; }

    public string AccountId { get; set; }

    public string ProjectIds { get; set; }

    public string Description { get; set; }

    public decimal? RunningBalance { get; set; }

    public string CurrencyCode { get; set; }

    public string AccountCode { get; set; }

    public string AccountCfOldacno { get; set; }

    public int? TranDate { get; set; }

    public int? Pv { get; set; }

    public char? Trial991 { get; set; }
}
