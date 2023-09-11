using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Dcdocument
{
    public int Id { get; set; }

    public string RefNo { get; set; }

    public int? DateRec { get; set; }

    public string Subject { get; set; }

    public string Author { get; set; }

    public int? ProjectId { get; set; }

    public string Keywords { get; set; }

    public string DocType { get; set; }

    public string SubDocType { get; set; }

    public int? ReceiverSender { get; set; }

    public string Status { get; set; }

    public int? UserId { get; set; }

    public string ReplytoRefno { get; set; }

    public int? Dept { get; set; }

    public string Createddate { get; set; }

    public char? Trial343 { get; set; }
}
