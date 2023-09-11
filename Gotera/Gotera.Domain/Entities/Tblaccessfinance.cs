using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblaccessfinance
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public string Username { get; set; }

    public bool? Banks { get; set; }

    public bool? Chartofaccounts { get; set; }

    public bool? Vendor { get; set; }

    public bool? Client { get; set; }

    public bool? Accounttype { get; set; }

    public bool? Incomebillentry { get; set; }

    public bool? Incomebillreview { get; set; }

    public bool? Incomebillapproval { get; set; }

    public bool? Income { get; set; }

    public bool? Incomereview { get; set; }

    public bool? Incomeapproval { get; set; }

    public bool? Billforpayment { get; set; }

    public bool? Billreview { get; set; }

    public bool? Billapproval { get; set; }

    public bool? Disbursement { get; set; }

    public bool? Disbursementapproval { get; set; }

    public bool? Voidcheck { get; set; }

    public bool? Paymentorder { get; set; }

    public bool? Billstatus { get; set; }

    public int? Timesheetapproval { get; set; }

    public bool? Tsreport { get; set; }

    public bool? Tssummary { get; set; }

    public bool? Tsstatus { get; set; }

    public bool? Pvattachement { get; set; }

    public bool? Collectionattachement { get; set; }

    public bool? Setelementattachement { get; set; }

    public bool? Attachementapproval { get; set; }

    public bool? Postdated { get; set; }

    public bool? Bankreconcilation { get; set; }

    public bool? Bankbalances { get; set; }

    public bool? Banktransaction { get; set; }

    public bool? Pvstatus { get; set; }

    public bool? Pvattachementreport { get; set; }

    public bool? Vendorexpenditure { get; set; }

    public string Createddate { get; set; }

    public string Createdby { get; set; }

    public string Updatedby { get; set; }

    public string Updateddate { get; set; }

    public bool? Documentreceiving { get; set; }

    public bool? Documentrequest { get; set; }

    public bool? Requestapproval { get; set; }

    public bool? Documentissue { get; set; }

    public bool? Documentreturn { get; set; }

    public bool? Documentstatus { get; set; }

    public bool? Issueddocuments { get; set; }

    public bool? Lostdocuments { get; set; }

    public bool? Payableattachement { get; set; }

    public bool? Payableapproval { get; set; }

    public bool? Journalsetup { get; set; }

    public bool? M3kmReview { get; set; }

    public bool? M3kmAppEng { get; set; }

    public bool? M3kmAppFin { get; set; }

    public bool? M3kmReports { get; set; }

    public char? Trial590 { get; set; }
}
