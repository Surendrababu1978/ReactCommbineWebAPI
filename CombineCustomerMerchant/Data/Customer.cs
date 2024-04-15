using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CombineCustomerMerchant.Data;

public partial class Customer
{
    [Key]
   public Guid CustomerId { set;  get; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public string PinCode { get; set; } = null!;

    //public object MapLocation { get; set; } = null!;
    public string MobileNo { get; set; } = null!;

    public string EMail { get; set; } = null!;

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }
}
