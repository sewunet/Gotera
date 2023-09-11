using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblagreement
{
    public int? Agreementid { get; set; }

    public int? Agreementtypeid { get; set; }

    public string Agreementname { get; set; }

    public int? Startdate { get; set; }

    public string PlateNo { get; set; }

    public int? Ownerid { get; set; }

    public string Ownername { get; set; }

    public int? Projectid { get; set; }

    public string Projectname { get; set; }

    public char? Trial645 { get; set; }
}
