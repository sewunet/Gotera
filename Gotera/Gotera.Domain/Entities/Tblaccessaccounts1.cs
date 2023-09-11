using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblaccessaccounts1
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public string Username { get; set; }

    public bool? Chkdashboard { get; set; }

    public bool? Chkcontacts { get; set; }

    public bool? Chktax { get; set; }

    public bool? ChkbankWritecheck { get; set; }

    public bool? ChkbankTransfere { get; set; }

    public bool? ChkbankRegistry { get; set; }

    public bool? ChkbankCheckregistry { get; set; }

    public bool? ChkbankVoidcheck { get; set; }

    public bool? ChkbankStatemententry { get; set; }

    public bool? ChkbankStatementreview { get; set; }

    public bool? ChkbankStatementapproval { get; set; }

    public bool? ChkbankStatementreport { get; set; }

    public bool? ChkbankReconciliation { get; set; }

    public bool? ChkbankUnreconciled { get; set; }

    public bool? ChkbankOutstanding { get; set; }

    public bool? ChksalesCollectionrequest { get; set; }

    public bool? ChksalesInvoicegoods { get; set; }

    public bool? ChksalesInvoiceServices { get; set; }

    public bool? ChksalesReceivepayment { get; set; }

    public bool? ChksalesPaymentsreceived { get; set; }

    public bool? ChksalesReceipts { get; set; }

    public bool? ChkpurchaseExpense { get; set; }

    public bool? ChkpurchaseRecurringexpense { get; set; }

    public bool? ChkpurchaseBillHo { get; set; }

    public bool? ChkpurchaseBillProjects { get; set; }

    public bool? ChkpurchaseBillServices { get; set; }

    public bool? ChkpurchasePaybill { get; set; }

    public bool? ChkpurchasePaymentsmade { get; set; }

    public bool? ChkpurchaseVendorcredit { get; set; }

    public bool? ChkpurchaseSettlement { get; set; }

    public bool? SettlementGoodsProjects { get; set; }

    public bool? SettlementServicesBoth { get; set; }

    public bool? ChkaccCharts { get; set; }

    public bool? ChkaccBeginingbalance { get; set; }

    public bool? ChkaccGeneraljournal { get; set; }

    public bool? ChkaccCheckregistry { get; set; }

    public bool? ChkaccPaymentpostaudit { get; set; }

    public bool? ChkappInvoiceHo { get; set; }

    public bool? ChkappReceiptHo { get; set; }

    public bool? ChkappPaybillHo { get; set; }

    public bool? ChkappSettlementHo { get; set; }

    public bool? ChkappSettlementProject { get; set; }

    public bool? ChkappTransfereProjects { get; set; }

    public bool? ChkappExpense { get; set; }

    public bool? ChkappExpenseProjects { get; set; }

    public bool? ChkappVendorcredit { get; set; }

    public bool? ChkappVendorcreditProjects { get; set; }

    public bool? ChkappBillProjects { get; set; }

    public bool? ChkappPaybillProjects { get; set; }

    public bool? ChkappGeneraljournal { get; set; }

    public bool? ChkappChartofaccounts { get; set; }

    public bool? ChkappAccountbegining { get; set; }

    public bool? ChkappSettGoodsHo { get; set; }

    public bool? ChkappSettServicesHo { get; set; }

    public bool? ChkappSettServicesP { get; set; }

    public bool? Chkrep1Profitloss { get; set; }

    public bool? Chkrep1Cashflow { get; set; }

    public bool? Chkrep1Balancesheet { get; set; }

    public bool? Chkrep1Sales { get; set; }

    public bool? Chkrep1Inventory { get; set; }

    public bool? Chkrep1Receivables { get; set; }

    public bool? Chkrep1Paymentsreceived { get; set; }

    public bool? Chkrep1Payables { get; set; }

    public bool? Chkrep1Purchaseexpense { get; set; }

    public bool? Chkrep1GovTaxes { get; set; }

    public bool? Chkrep1Chartofaccounts { get; set; }

    public bool? Chkrep1Accountbeg { get; set; }

    public bool? Chkrep1VendorCustomerBeg { get; set; }

    public bool? Chkrep1Trailbalance { get; set; }

    public bool? Chkrep1Generaljournal { get; set; }

    public bool? Chkrep1Gj { get; set; }

    public bool? Chkrep1Vendorcustomerlrdger { get; set; }

    public bool? Chkrep2Engvsfin { get; set; }

    public bool? Chkrep2TsPayables { get; set; }

    public bool? Chkrep2Payablevsbudget { get; set; }

    public bool? Chkrep2Payablevspayment { get; set; }

    public bool? Chkrep2Payableowned { get; set; }

    public bool? Chkrep2Rentalbalance { get; set; }

    public bool? Chkrep2Rentalstatus { get; set; }

    public bool? Chkrep2Banktrans { get; set; }

    public bool? Chkrep2Paymentpostaudit { get; set; }

    public bool? Chkrep2Reversedtran { get; set; }

    public bool? Chkrep2Accounttranlist { get; set; }

    public bool? Chkrep2Tranwithoutattachement { get; set; }

    public bool? Chkrep2Pvstatus { get; set; }

    public bool? Chkrep2PvAattachement { get; set; }

    public bool? Chkrep2Accountbalance { get; set; }

    public bool? Chkrep2Vendorjournal { get; set; }

    public bool? Chkrep2Vendorexpenditure { get; set; }

    public bool? Chkrep2Purchaseledger { get; set; }

    public bool? Chkrep2Projectaccountlist { get; set; }

    public bool? Chkrep2Postdatedchecks { get; set; }

    public bool? Chkrep2Outstandingpayment { get; set; }

    public bool? Chkrep2Budgetrequestequip { get; set; }

    public bool? Chkrep2Boxfile { get; set; }

    public bool? ChkadminPostdatedchecks { get; set; }

    public bool? ChkadminTranreversal { get; set; }

    public bool? ChkadminUpdateapppayments { get; set; }

    public bool? ChkadminUpdateappnonepayments { get; set; }

    public string Createdby { get; set; }

    public DateTime? Createddate { get; set; }

    public bool? ReversalBill { get; set; }

    public bool? ReversalPaybill { get; set; }

    public bool? ReversalPv { get; set; }

    public bool? ReversalJv { get; set; }

    public bool? Pettycash { get; set; }

    public bool? Billforpettycash { get; set; }

    public bool? Paymentforpettycash { get; set; }

    public bool? Pettycashdisbursement { get; set; }

    public bool? Pettycashsettlement { get; set; }

    public bool? Pettycashsettlementapp { get; set; }

    public bool? Pettyattachement { get; set; }

    public bool? Pettyattachementapp { get; set; }

    public char? Trial580 { get; set; }
}
