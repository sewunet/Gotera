using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblaccessdocument
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public string Username { get; set; }

    public bool? Documenttype { get; set; }

    public bool? Incoming { get; set; }

    public bool? Outgoing { get; set; }

    public bool? Internal { get; set; }

    public bool? Memo { get; set; }

    public bool? Drawing { get; set; }

    public bool? Otherfiles { get; set; }

    public bool? Docreports { get; set; }

    public string Createdby { get; set; }

    public string Createddate { get; set; }

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

    public bool? Bondentry { get; set; }

    public bool? Bondapproval { get; set; }

    public bool? Bondrenewal { get; set; }

    public bool? Bondnotification { get; set; }

    public bool? Bondreports { get; set; }

    public char? Trial583 { get; set; }
}
