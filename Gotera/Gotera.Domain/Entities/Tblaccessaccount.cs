using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblaccessaccount
{
    public int? Id { get; set; }

    public int? Userid { get; set; }

    public string Username { get; set; }

    public bool? Accounttype { get; set; }

    public bool? Chartofaccount { get; set; }

    public bool? Customerbegining { get; set; }

    public bool? Vendorbegining { get; set; }

    public bool? Accountbegining { get; set; }

    public bool? TasksAr { get; set; }

    public bool? TasksAp { get; set; }

    public bool? TasksReceipts { get; set; }

    public bool? TasksPayments { get; set; }

    public bool? TasksSettlements { get; set; }

    public bool? TasksGj { get; set; }

    public bool? AppChartofaccounts { get; set; }

    public bool? AppCustomerbegining { get; set; }

    public bool? AppVendorbegining { get; set; }

    public bool? AppAccountbegining { get; set; }

    public bool? AppAr { get; set; }

    public bool? AppAp { get; set; }

    public bool? AppReceipts { get; set; }

    public bool? AppPayments { get; set; }

    public bool? AppSettlements { get; set; }

    public bool? AppGj { get; set; }

    public bool? RepAr { get; set; }

    public bool? RepAp { get; set; }

    public bool? RepGl { get; set; }

    public bool? RepPayroll { get; set; }

    public bool? RepInventory { get; set; }

    public bool? RepFinancialstatement { get; set; }

    public string Createdby { get; set; }

    public string Createddate { get; set; }

    public string Updatedby { get; set; }

    public string Updateddate { get; set; }

    public bool? TasksBill { get; set; }

    public bool? AppDisbursement { get; set; }

    public bool? Postdated { get; set; }

    public bool? Bankreconcilation { get; set; }

    public bool? Bankbalances { get; set; }

    public bool? Banktransaction { get; set; }

    public bool? Pvstatus { get; set; }

    public bool? Pvattachementreport { get; set; }

    public bool? Vendorexpenditure { get; set; }

    public bool? Statemententry { get; set; }

    public bool? Statementreview { get; set; }

    public bool? Statementapproval { get; set; }

    public bool? Statemenreport { get; set; }

    public bool? Checkregistry { get; set; }

    public bool? Bankreconciliation { get; set; }

    public bool? Unreconciledrecords { get; set; }

    public bool? Outstanding { get; set; }

    public bool? Postaudit { get; set; }

    public bool? Bankregistry { get; set; }

    public bool? Paymentorder { get; set; }

    public bool? Voidcheck { get; set; }

    public bool? Projectpayment { get; set; }

    public bool? Servicecharge { get; set; }

    public bool? Reversal { get; set; }

    public bool? Billforpettycash { get; set; }

    public bool? Paymentforpettycash { get; set; }

    public bool? Pettycashdisbursement { get; set; }

    public bool? Pettycashsettlement { get; set; }

    public bool? Pettycashsettlementapp { get; set; }

    public bool? Pettyattachement { get; set; }

    public bool? Pettyattachementapp { get; set; }

    public bool? AppProjectPayment { get; set; }

    public bool? Bankconfirmation { get; set; }

    public bool? Admiupdaterecords { get; set; }

    public char? Trial577 { get; set; }
}
