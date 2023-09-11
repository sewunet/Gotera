using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblarchiveactivity
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public string Username { get; set; }

    public int? Deptid { get; set; }

    public string Documenttype { get; set; }

    public int? PvNo { get; set; }

    public string CollectionReference { get; set; }

    public string Reason { get; set; }

    public string Status { get; set; }

    public string PayeePayerName { get; set; }

    public decimal? Amount { get; set; }

    public int? Daterequested { get; set; }

    public int? Dateissued { get; set; }

    public string Issuedby { get; set; }

    public int? Datereturned { get; set; }

    public DateTime? Createddate { get; set; }

    public string Createdby { get; set; }

    public string Approvedby { get; set; }

    public DateTime? Approveddate { get; set; }

    public bool? Isapproved { get; set; }

    public char? Trial645 { get; set; }
}
