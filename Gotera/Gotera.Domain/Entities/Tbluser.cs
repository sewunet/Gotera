using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tbluser
{
    public int Userid { get; set; }

    public string Username { get; set; }

    public string Userpassword { get; set; }

    public string Fullname { get; set; }

    public int? SupervisorId { get; set; }

    public int? DeptId { get; set; }

    public int? PosId { get; set; }

    public bool? Canlogin { get; set; }

    public bool? Planning { get; set; }

    public bool? Contracts { get; set; }

    public bool? Engineering { get; set; }

    public bool? Operations { get; set; }

    public bool? Equipment { get; set; }

    public bool? Inventory { get; set; }

    public bool? Purchasing { get; set; }

    public bool? Hrm { get; set; }

    public bool? Finance { get; set; }

    public bool? Itemsetup { get; set; }

    public bool? Eqsetup { get; set; }

    public bool? Dataentryonly { get; set; }

    public bool? Reportsonly { get; set; }

    public bool? Dataandreports { get; set; }

    public bool? Request { get; set; }

    public bool? Approval { get; set; }

    public bool? Createuser { get; set; }

    public int? ApprovalLevel { get; set; }

    public bool? Finrequest { get; set; }

    public bool? Quotation { get; set; }

    public bool? Store { get; set; }

    public bool? Audit { get; set; }

    public int? Reslevel { get; set; }

    public bool? ApprovalSr { get; set; }

    public bool? ApprovalPr { get; set; }

    public bool? BankSetup { get; set; }

    public bool? BankTran { get; set; }

    public string Status { get; set; }

    public bool? Qrequest { get; set; }

    public bool? Qapproval { get; set; }

    public bool? Qinspection { get; set; }

    public bool? Qddh { get; set; }

    public bool? Qdh { get; set; }

    public bool? Qwop { get; set; }

    public bool? Tsapp1 { get; set; }

    public bool? Tsapp2 { get; set; }

    public bool? Tsapp3 { get; set; }

    public bool? Tsdept { get; set; }

    public bool? Tsapp5 { get; set; }

    public bool? Tsapp6 { get; set; }

    public bool? Tsfin { get; set; }

    public bool? Createbill { get; set; }

    public bool? Billreview { get; set; }

    public bool? Billapproval { get; set; }

    public bool? Createdisbu { get; set; }

    public bool? Disbureview { get; set; }

    public bool? Disbuapproval { get; set; }

    public bool? Ipccreate { get; set; }

    public bool? Ipcreview { get; set; }

    public bool? Ipcapprove { get; set; }

    public bool? Ipcreport { get; set; }

    public bool? Manage { get; set; }

    public bool? Managecreate { get; set; }

    public bool? Managereview { get; set; }

    public bool? Manageapproval { get; set; }

    public bool? Manageadmin { get; set; }

    public bool? Isreviewed { get; set; }

    public string Reviewedby { get; set; }

    public string Revieweddate { get; set; }

    public bool? Isapproved { get; set; }

    public string Approvedby { get; set; }

    public string Approveddate { get; set; }

    public int? Createdby { get; set; }

    public string Createdbyname { get; set; }

    public string Createddate { get; set; }

    public string Updatedby { get; set; }

    public string Updateddate { get; set; }

    public bool? Isactive { get; set; }

    public bool? Isdeleted { get; set; }

    public bool? Bankreconciliation { get; set; }

    public bool? Bankstatement { get; set; }

    public bool? Other1 { get; set; }

    public bool? Other2 { get; set; }

    public bool? Other3 { get; set; }

    public bool? Other4 { get; set; }

    public bool? Payrolltimesheet { get; set; }

    public bool? Employee { get; set; }

    public bool? Clientcreation { get; set; }

    public bool? Clientapproval { get; set; }

    public bool? Agreement1 { get; set; }

    public bool? Agreement2 { get; set; }

    public bool? Agreement3 { get; set; }

    public bool? Agreement4 { get; set; }

    public bool? Agreement5 { get; set; }

    public bool? Isadmin { get; set; }

    public bool? Isprojectsite { get; set; }

    public int? Projectid { get; set; }

    public string Projectname { get; set; }

    public string SupervisorName { get; set; }

    public char? Trial913 { get; set; }
}
