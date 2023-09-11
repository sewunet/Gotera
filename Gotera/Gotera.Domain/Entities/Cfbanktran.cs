using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Cfbanktran
{
    public int Id { get; set; }

    public int? TrDate { get; set; }

    public int? TrWithdrawDate { get; set; }

    public int? ProjectId { get; set; }

    public decimal? CashAmount { get; set; }

    public decimal? Vat { get; set; }

    public decimal? Wht { get; set; }

    public int? Fcode1 { get; set; }

    public int? Fcode2 { get; set; }

    public string CheckNo { get; set; }

    public string PvNo { get; set; }

    public int? PaidTo { get; set; }

    public int? BankId { get; set; }

    public string Remark { get; set; }

    public int? Userid { get; set; }

    public string CreatedDate { get; set; }

    public string RecordType { get; set; }

    public string Status { get; set; }

    public int? ApprovedBy { get; set; }

    public string Void { get; set; }

    public decimal? CashIn { get; set; }

    public decimal? CashOut { get; set; }

    public char? Trial317 { get; set; }
}
