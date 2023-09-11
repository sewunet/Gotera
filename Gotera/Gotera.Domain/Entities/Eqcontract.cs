using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class Eqcontract
{
    public int Id { get; set; }

    public int? Project { get; set; }

    public string PlateNo { get; set; }

    public string EquipmentName { get; set; }

    public decimal? Capacity { get; set; }

    public int? DateEntered { get; set; }

    public decimal? Rentrate05 { get; set; }

    public decimal? Rentrate57 { get; set; }

    public decimal? Rentrate710 { get; set; }

    public decimal? Rentrate1015 { get; set; }

    public decimal? Rentrate15More { get; set; }

    public string Status { get; set; }

    public int? CreatedBy { get; set; }

    public char? Trial410 { get; set; }
}
