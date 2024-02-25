using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class AffiliatedCustomer
{
    public int AffiliateCustomerId { get; set; }

    public int AffiliateAgentId { get; set; }

    public short Status { get; set; }

    public virtual AffiliateAgent AffiliateAgent { get; set; } = null!;

    public virtual Customer AffiliateCustomer { get; set; } = null!;
}
