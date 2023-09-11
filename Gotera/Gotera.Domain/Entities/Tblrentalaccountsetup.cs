using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Tblrentalaccountsetup
{
    public int Id { get; set; }

    public string StartGlRentalpayment { get; set; }

    public string EndGlRentalpayment { get; set; }

    public string StartGlRentaladvance { get; set; }

    public string EndGlRentaladvance { get; set; }

    public string StartGlRentaladvancerepayment { get; set; }

    public string EndGlRentaladvancerepayment { get; set; }

    public string StartGlFuel { get; set; }

    public string EndGlFuel { get; set; }

    public string StartGlMaterial { get; set; }

    public string EndGlMaterial { get; set; }

    public string StartGlVehicle { get; set; }

    public string EndGlVehicle { get; set; }

    public string StartGlMachinery { get; set; }

    public string EndGlMachinery { get; set; }

    public string StartGlTransport { get; set; }

    public string EndGlTransport { get; set; }

    public string StartGlOperatorsalary { get; set; }

    public string EndGlOperatorsalary { get; set; }

    public string StartGlOtherdeduction { get; set; }

    public string EndGlOtherdeduction { get; set; }

    public string Vat { get; set; }

    public string Wht { get; set; }

    public string StartAccountpayable { get; set; }

    public string EndAccountpayable { get; set; }

    public char? Trial903 { get; set; }
}
