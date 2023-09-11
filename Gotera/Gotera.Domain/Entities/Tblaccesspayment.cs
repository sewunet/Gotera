using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblaccesspayment
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public string Username { get; set; }

    public bool? Updatebill { get; set; }

    public bool? Rejectbudget { get; set; }

    public bool? Request { get; set; }

    public int? Approval { get; set; }

    public bool? Confirmation { get; set; }

    public bool? Rentalbill { get; set; }

    public bool? Rentalbillm3km { get; set; }

    public bool? Paymentreports { get; set; }

    public bool? Statemententry { get; set; }

    public bool? Statementreview { get; set; }

    public bool? Statementapproval { get; set; }

    public bool? Statemenreport { get; set; }

    public bool? Checkregistry { get; set; }

    public bool? Bankreconciliation { get; set; }

    public bool? Unreconciledrecords { get; set; }

    public bool? Outstanding { get; set; }

    public string Createdby { get; set; }

    public string Createddate { get; set; }

    public string Updatedby { get; set; }

    public string Updateddate { get; set; }

    public bool? Dedaccountsetup { get; set; }

    public bool? Rentaldeductions { get; set; }

    public bool? Rentaldeductionsapproval { get; set; }

    public char? Trial593 { get; set; }
}
