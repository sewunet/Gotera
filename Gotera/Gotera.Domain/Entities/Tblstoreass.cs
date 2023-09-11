using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblstoreass
{
    public int StoreassId { get; set; }

    public int? Reqdetailid { get; set; }

    public int? Storeid { get; set; }

    public int? Condid { get; set; }

    public decimal? Appqty { get; set; }

    public DateTime? Appdate { get; set; }

    public string Appby { get; set; }

    public bool? Issued { get; set; }

    public string Sivno { get; set; }

    public int? SassstatId { get; set; }

    public DateTime? SassstatDate { get; set; }

    public char? Trial906 { get; set; }
}
