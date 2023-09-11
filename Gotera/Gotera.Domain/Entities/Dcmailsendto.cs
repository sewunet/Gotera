using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Dcmailsendto
{
    public int Id { get; set; }

    public int? MailId { get; set; }

    public int? UserId { get; set; }

    public int? SendTo { get; set; }

    public int? Status { get; set; }

    public char? Trial224 { get; set; }
}
