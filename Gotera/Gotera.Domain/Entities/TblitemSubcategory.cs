using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class TblitemSubcategory
{
    public int Id { get; set; }

    public int? CatId { get; set; }

    public string SubName { get; set; }

    public int? ProjectId { get; set; }

    public int? SortOrder { get; set; }

    public string GlInventoryAccount { get; set; }

    public string GlSalesAccount { get; set; }

    public string GlSalesCostAccount { get; set; }

    public bool? Isinventoryitem { get; set; }

    public string Updatedby { get; set; }

    public DateTime? Updateddate { get; set; }

    public char? Trial828 { get; set; }
}
