using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblbond
{
    public int Id { get; set; }

    public int? BondTypeId { get; set; }

    public string BondTypeDescription { get; set; }

    public string Reference { get; set; }

    public int? Clientid { get; set; }

    public string Clientname { get; set; }

    public int? BankInsuranceId { get; set; }

    public string BankInsuranceName { get; set; }

    public int? StartDate { get; set; }

    public int? EndDate { get; set; }

    public int? DefectLiabliltyPeriod { get; set; }

    public string Status { get; set; }

    public decimal? Amount { get; set; }

    public int? Projectid { get; set; }

    public string ProjectName { get; set; }

    public string Description { get; set; }

    public DateTime? Createddate { get; set; }

    public string Createdby { get; set; }

    public bool? Isapproved { get; set; }

    public DateTime? Approveddate { get; set; }

    public string Approvedby { get; set; }

    public string Updatedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public char? Trial652 { get; set; }
}
