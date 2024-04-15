using System;
using System.Collections.Generic;

namespace CombineCustomerMerchant.Data;

public partial class Supplier
{
    public int SupplierId { get; set; }

    public string Name { get; set; } = null!;

    public string? Address { get; set; }

    public string? City { get; set; }

    public string PinCode { get; set; } = null!;

   
    public string? MapPosition { get; set; }

    public string MobileNo { get; set; } = null!;

    public string EMail { get; set; } = null!;
}
