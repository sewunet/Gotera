using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblaccessadmin
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public string Username { get; set; }

    public bool? Paymentrequest { get; set; }

    public bool? Purchase { get; set; }

    public bool? Specialapproval { get; set; }

    public bool? Updatepo { get; set; }

    public bool? Updategrn { get; set; }

    public bool? Passwordchange { get; set; }

    public bool? Usermanagement { get; set; }

    public bool? Accessprivilege { get; set; }

    public bool? Clientvendor { get; set; }

    public bool? Project { get; set; }

    public bool? Department { get; set; }

    public bool? Storeclassification { get; set; }

    public string Createdby { get; set; }

    public string Createddate { get; set; }

    public string Updatedby { get; set; }

    public string Updateddate { get; set; }

    public bool? CrQdesigner { get; set; }

    public bool? CrViewer { get; set; }

    public char? Trial580 { get; set; }
}
