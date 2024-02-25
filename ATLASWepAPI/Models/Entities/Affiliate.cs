using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class Affiliate
{
    public int Id { get; set; }

    public int AddressId { get; set; }

    public string? AdminComment { get; set; }

    public string? FriendlyUrlName { get; set; }

    public bool Deleted { get; set; }

    public bool Active { get; set; }

    public string? AgentCode { get; set; }

    public bool? RequestingForActivation { get; set; }

    public DateTime? ActivationDate { get; set; }

    public string? ReferralLink { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual ICollection<AffiliateCommissionMapping> AffiliateCommissionMappings { get; set; } = new List<AffiliateCommissionMapping>();
}
