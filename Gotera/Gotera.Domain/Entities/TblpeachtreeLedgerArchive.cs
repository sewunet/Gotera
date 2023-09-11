using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class TblpeachtreeLedgerArchive
{
    public double? Id { get; set; }

    public double? TranDate { get; set; }

    public string AccountId { get; set; }

    public string AccountDescription { get; set; }

    public DateTime? Date { get; set; }

    public string Reference { get; set; }

    public string Jrnl { get; set; }

    public string TransDescription { get; set; }

    public double? DebitAmt { get; set; }

    public double? CreditAmt { get; set; }

    public double? Balance { get; set; }

    public string JobId { get; set; }

    public double? TransAmount { get; set; }

    public string CustomerId { get; set; }

    public string CustomerName { get; set; }

    public string VendorId { get; set; }

    public string VendorName { get; set; }

    public string EmployeeId { get; set; }

    public string EmployeeName { get; set; }

    public string ItemId { get; set; }

    public string ItemDescription { get; set; }

    public string LineDescription { get; set; }

    public string JobDescription { get; set; }

    public string PeachtreeCompany { get; set; }

    public double? Efy { get; set; }

    public char? Trial848 { get; set; }
}
