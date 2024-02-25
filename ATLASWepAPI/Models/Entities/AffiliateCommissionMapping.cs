using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class AffiliateCommissionMapping
{
    public int Id { get; set; }

    public int CommissionId { get; set; }

    public int AffiliateId { get; set; }

    public virtual Affiliate Affiliate { get; set; } = null!;

    public virtual Commission Commission { get; set; } = null!;
}
