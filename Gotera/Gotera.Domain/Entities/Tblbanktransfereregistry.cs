using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblbanktransfereregistry
{
    public int Id { get; set; }

    public string Accountrectype { get; set; }

    public string PvNo { get; set; }

    public string ItemType { get; set; }

    public int? PoReqNo { get; set; }

    public decimal? Totalamount { get; set; }

    public string Remark { get; set; }

    public bool? Isprojecttran { get; set; }

    public string Reqid { get; set; }

    public char? Trial648 { get; set; }
}
