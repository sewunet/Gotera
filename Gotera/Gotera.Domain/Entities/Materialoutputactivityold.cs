using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Materialoutputactivityold
{
    public int Id { get; set; }

    public decimal Dispensedquantity { get; set; }

    public string Storemanname { get; set; }

    public string Receivername { get; set; }

    public string Dispenseddate { get; set; }

    public string Truckplatenumber { get; set; }

    public decimal Materialprice { get; set; }

    public string Clientauthorizer { get; set; }

    public string Reportedby { get; set; }

    public bool Isdeleted { get; set; }

    public string Reason { get; set; }

    public DateTime Createddate { get; set; }

    public string Createdby { get; set; }

    public bool Isreviewed { get; set; }

    public DateTime? Revieweddate { get; set; }

    public string Reviewedby { get; set; }

    public bool Isapproved { get; set; }

    public DateTime? Approveddate { get; set; }

    public string Approvedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public string Updatedby { get; set; }

    public int Projectid { get; set; }

    public int Siteid { get; set; }

    public int Materialtypeid { get; set; }

    public int Managerid { get; set; }

    public int Clientid { get; set; }

    public string Machineryplatenumber { get; set; }

    public decimal Withholding { get; set; }

    public decimal Vat { get; set; }

    public string Projectname { get; set; }

    public string Sitename { get; set; }

    public string Materialtypename { get; set; }

    public string Materialtypeunit { get; set; }

    public string Clientname { get; set; }

    public int Agreementtypeid { get; set; }

    public int Agreementid { get; set; }

    public string Agreementname { get; set; }

    public string Managername { get; set; }

    public int? Erpdate { get; set; }

    public int? Period { get; set; }

    public int? Itemid { get; set; }

    public int? Userid { get; set; }

    public int? ScId { get; set; }

    public string SivNo { get; set; }

    public string GrnNo { get; set; }

    public int? Status { get; set; }

    public string Materialtype { get; set; }

    public bool? Isactive { get; set; }

    public char? Trial498 { get; set; }
}
