using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class Commission
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool UsePercentage { get; set; }

    public decimal PercentOrAmount { get; set; }

    public int CommissionAppliesTo { get; set; }

    public bool IsActive { get; set; }

    public int? Order { get; set; }

    public DateTime? EffectivityStartDate { get; set; }

    public DateTime? EffectivityEndDate { get; set; }

    public virtual ICollection<AffiliateCommissionMapping> AffiliateCommissionMappings { get; set; } = new List<AffiliateCommissionMapping>();

    public virtual ICollection<CommissionProduct> CommissionProducts { get; set; } = new List<CommissionProduct>();

    public virtual ICollection<CommissionStore> CommissionStores { get; set; } = new List<CommissionStore>();
}
