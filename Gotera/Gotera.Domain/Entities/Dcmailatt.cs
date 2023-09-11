using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Dcmailatt
{
    public int Id { get; set; }

    public int? MailId { get; set; }

    public string FileName { get; set; }

    public char? Trial221 { get; set; }
}
