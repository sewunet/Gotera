using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblaccessequipment
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public string Username { get; set; }

    public bool? Propertyregistry { get; set; }

    public bool? Propertyreview { get; set; }

    public bool? Propertyapproval { get; set; }

    public bool? Propertyupdate { get; set; }

    public bool? Pmschedule { get; set; }

    public bool? Dailyactivity { get; set; }

    public bool? Dailyactivityapp { get; set; }

    public bool? Dailyactivitykm { get; set; }

    public bool? Ownedequipment { get; set; }

    public bool? Quotationrequest { get; set; }

    public bool? Quotationapproval { get; set; }

    public bool? Inspection { get; set; }

    public bool? Caniblization { get; set; }

    public bool? Outsource { get; set; }

    public bool? Workshop { get; set; }

    public bool? Workorderapproval { get; set; }

    public bool? Workorderprint { get; set; }

    public bool? Maintcompletion { get; set; }

    public bool? Jobstatus { get; set; }

    public bool? Equipmentparts { get; set; }

    public bool? Tools { get; set; }

    public bool? Equipmentcategory { get; set; }

    public bool? Pmtypes { get; set; }

    public bool? Problemcodes { get; set; }

    public bool? Equipmentreports { get; set; }

    public string Createdby { get; set; }

    public string Createddate { get; set; }

    public string Updatedby { get; set; }

    public string Updateddate { get; set; }

    public bool? Ownedeqattachemententry { get; set; }

    public bool? Ownedeqattachementapp { get; set; }

    public bool? Documentreport { get; set; }

    public char? Trial590 { get; set; }
}
