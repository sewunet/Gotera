using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Vehicle
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Model { get; set; }

    public string Make { get; set; }

    public string Platenumber { get; set; }

    public decimal Loadingcapacity { get; set; }

    public bool Isoperational { get; set; }

    public string Reason { get; set; }

    public decimal Fuelconsumptionrate { get; set; }

    public decimal Fuelholdingcapacity { get; set; }

    public int Odometerreading { get; set; }

    public bool Isdeleted { get; set; }

    public DateTime Createddate { get; set; }

    public string Createdby { get; set; }

    public bool Isreviewed { get; set; }

    public DateTime? Revieweddate { get; set; }

    public string Reviewedby { get; set; }

    public bool Isapproved { get; set; }

    public DateTime? Approveddate { get; set; }

    public string Approvedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public string Updatedby { get; set; }

    public int Vehicletypeid { get; set; }

    public string Vehiclenumber { get; set; }

    public int Clientid { get; set; }

    public bool Isactive { get; set; }

    public char? Trial959 { get; set; }
}
