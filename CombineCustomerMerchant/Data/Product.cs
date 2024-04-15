using System;
using System.Collections.Generic;

namespace CombineCustomerMerchant.Data;

public partial class Product
{
    public Guid ProductId { get; set; }

    public string? Category { get; set; }

    public string Description { get; set; } = null!;

    public string? Uom { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? Moq { get; set; }

    public byte[]? ProductImg { get; set; }
}
