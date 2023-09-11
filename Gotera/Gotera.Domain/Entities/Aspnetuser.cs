using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Aspnetuser
{
    public string Id { get; set; }

    public string Firstname { get; set; }

    public string Middlename { get; set; }

    public string Lastname { get; set; }

    public DateTime Createddate { get; set; }

    public string Createdby { get; set; }

    public bool Isreviewed { get; set; }

    public DateTime? Revieweddate { get; set; }

    public string Reviewedby { get; set; }

    public bool Isapproved { get; set; }

    public string Approvedby { get; set; }

    public DateTime? Approveddate { get; set; }

    public string Reasonfordelete { get; set; }

    public bool Isdeleted { get; set; }

    public string Email { get; set; }

    public string Passwordhash { get; set; }

    public string Username { get; set; }

    public bool Canseedataentry { get; set; }

    public bool Canseeactivitytracking { get; set; }

    public bool Canseefuelinputactivity { get; set; }

    public bool Canseefueloutputactivity { get; set; }

    public bool Canseematerialinputactivity { get; set; }

    public bool Canseematerialoutputactivity { get; set; }

    public bool Canseemachineryactivity { get; set; }

    public bool Canseevehicleactivity { get; set; }

    public bool Canseetransportvehicleactivity { get; set; }

    public bool Canseetimesheetactivity { get; set; }

    public bool Canseebillactivity { get; set; }

    public bool Canseecollectionactivity { get; set; }

    public bool Canseedisbursmentactivity { get; set; }

    public bool Canseemanage { get; set; }

    public bool Canseemanagestakeholder { get; set; }

    public bool Canseemanagelocality { get; set; }

    public bool Canseemanageproject { get; set; }

    public bool Canseemanagesite { get; set; }

    public bool Canseemanageagreement { get; set; }

    public bool Canseemanageserviceagreement { get; set; }

    public bool Canseemanagesalesagreement { get; set; }

    public bool Canseemanagemachineryagreement { get; set; }

    public bool Canseemanagevehicleagreement { get; set; }

    public bool Canseemanagetransportvehicleagreement { get; set; }

    public bool Canseemanagecapitalagreement { get; set; }

    public bool Canseemanagepersonnel { get; set; }

    public bool Canseemanageemployee { get; set; }

    public bool Canseemanagemanagertype { get; set; }

    public bool Canseemanagemanager { get; set; }

    public bool Canseemanageuser { get; set; }

    public bool Canseemanageproperty { get; set; }

    public bool Canseemanagemachinery { get; set; }

    public bool Canseemanagevehicle { get; set; }

    public bool Canseemanagevehicletype { get; set; }

    public bool Canseemanagerealestate { get; set; }

    public bool Canseemanageequipmenttype { get; set; }

    public bool Canseemanagematerialtype { get; set; }

    public bool Canseemanagefinance { get; set; }

    public bool Canseemanageallowancetype { get; set; }

    public bool Canseemanagebank { get; set; }

    public bool Canseemanageemployeeloan { get; set; }

    public bool Canseemanageaccount { get; set; }

    public bool Canseemanagesettings { get; set; }

    public bool Canseemanagetaxbracket { get; set; }

    public bool Canseemanagepension { get; set; }

    public bool Canseereport { get; set; }

    public bool Canseefuelreport { get; set; }

    public bool Canseematerialreport { get; set; }

    public bool Canseemachineryreport { get; set; }

    public bool Canseevehiclereport { get; set; }

    public bool Canseetransportvehiclereport { get; set; }

    public bool Canseebillreport { get; set; }

    public bool Canseecollectionreport { get; set; }

    public bool Canseedisbursmentreport { get; set; }

    public bool Canseeclientreport { get; set; }

    public bool Canseebankreport { get; set; }

    public bool Canseeprogressreport { get; set; }

    public bool Canseenetcashflowreport { get; set; }

    public bool Canseepayrollreport { get; set; }

    public string Codes { get; set; }

    public string Roles { get; set; }

    public bool? Isactive { get; set; }

    public bool Canseearchive { get; set; }

    public bool Canseefuelinputarchive { get; set; }

    public bool Canseefueloutputarchive { get; set; }

    public bool Canseematerialinputarchive { get; set; }

    public bool Canseematerialoutputarchive { get; set; }

    public bool Canseemachineryarchive { get; set; }

    public bool Canseevehiclearchive { get; set; }

    public bool Canseetransportvehiclearchive { get; set; }

    public bool Canseetimesheetarchive { get; set; }

    public bool Canseebillarchive { get; set; }

    public bool Canseecollectionarchive { get; set; }

    public bool Canseedisbursmentarchive { get; set; }

    public char? Trial275 { get; set; }

    public virtual ICollection<Aspnetuserrole> Aspnetuserroles { get; set; } = new List<Aspnetuserrole>();
}
