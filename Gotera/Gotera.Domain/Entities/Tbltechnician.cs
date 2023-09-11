using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tbltechnician
{
    public int TecId { get; set; }

    public string TecName { get; set; }

    public string EducationLevel { get; set; }

    public string EducationField { get; set; }

    public string Status { get; set; }

    public string JobTitle { get; set; }

    public string ServiceYear { get; set; }

    public string Remark { get; set; }

    public int? LoginId { get; set; }

    public char? Trial910 { get; set; }
}
