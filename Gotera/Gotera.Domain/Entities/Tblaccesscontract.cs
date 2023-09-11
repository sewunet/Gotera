using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblaccesscontract
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public string Username { get; set; }

    public bool? Agreementtype { get; set; }

    public bool? Field1 { get; set; }

    public bool? Capital { get; set; }

    public bool? Machineryrental { get; set; }

    public bool? Sales { get; set; }

    public bool? Service { get; set; }

    public bool? Vehiclerental { get; set; }

    public bool? Vehicletransport { get; set; }

    public bool? Purchase { get; set; }

    public bool? Agreementreport { get; set; }

    public string Createdby { get; set; }

    public string Createddate { get; set; }

    public string Updatedby { get; set; }

    public string Updateddate { get; set; }

    public bool? Appcapital { get; set; }

    public int? Appmachineryrental { get; set; }

    public int? Appsales { get; set; }

    public int? Appservice { get; set; }

    public int? Appvehiclerental { get; set; }

    public int? Appvehicletransport { get; set; }

    public bool? Apppurchase { get; set; }

    public bool? Admincapital { get; set; }

    public bool? Adminmachinery { get; set; }

    public bool? Adminsales { get; set; }

    public bool? Adminservice { get; set; }

    public bool? Adminvehicle { get; set; }

    public bool? Admintransport { get; set; }

    public bool? Adminpurchase { get; set; }

    public char? Trial583 { get; set; }
}
