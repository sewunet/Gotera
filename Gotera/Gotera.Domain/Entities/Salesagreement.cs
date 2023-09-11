using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Salesagreement
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Installmentone { get; set; }

    public string Paymentdateone { get; set; }

    public decimal Installmenttwo { get; set; }

    public string Paymentdatetwo { get; set; }

    public decimal Installmentthree { get; set; }

    public string Paymentdatethree { get; set; }

    public decimal Installmentfour { get; set; }

    public string Paymentdatefour { get; set; }

    public string Agreementdate { get; set; }

    public decimal Agreementsize { get; set; }

    public decimal Outstandingbalance { get; set; }

    public bool? Isactive { get; set; }

    public string Reason { get; set; }

    public string Agreementnumber { get; set; }

    public string Propertyname { get; set; }

    public int Propertyid { get; set; }

    public bool Isdeleted { get; set; }

    public bool Isincomegenerating { get; set; }

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

    public int Sellerid { get; set; }

    public int Buyerid { get; set; }

    public int Managerid { get; set; }

    public int Propertytypeid { get; set; }

    public int? ErpDate { get; set; }

    public char? Trial563 { get; set; }

    public virtual Manager Manager { get; set; }

    public virtual Tblproject Project { get; set; }

    public virtual Propertytype Propertytype { get; set; }

    public virtual Tblvendor Seller { get; set; }
}
