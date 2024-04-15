using System;
using System.Collections.Generic;

namespace CombineCustomerMerchant.Data;

public partial class Merchant
{
    public int MerChantId { get; set; }

    public string Name { get; set; } = null!;

    public string? Address { get; set; }

    public string? City { get; set; }


    public string? GSTNO { get; set; }

    public string? AAdhaarNo { get; set; }

    public string PinCode { get; set; } = null!;

    public string MobileNo { get; set; } = null!;

    public string EMail { get; set; } = null!;


    public string? MapPosition { get; set; }
}
