using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Dcmail
{
    public int Id { get; set; }

    public int? Sender { get; set; }

    public int? Receiver { get; set; }

    public string Subject { get; set; }

    public string Body { get; set; }

    public string Attachement { get; set; }

    public string Status { get; set; }

    public int? Readstatus { get; set; }

    public int? DateRcvd { get; set; }

    public string TimeRcvd { get; set; }

    public char? Trial217 { get; set; }
}
