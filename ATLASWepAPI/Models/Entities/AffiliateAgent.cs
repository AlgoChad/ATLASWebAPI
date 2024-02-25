using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class AffiliateAgent
{
    public int AffiliateAgentId { get; set; }

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string ReferralLink { get; set; } = null!;

    public string ReferralCode { get; set; } = null!;

    public short Status { get; set; }

    public virtual Customer AffiliateAgentNavigation { get; set; } = null!;

    public virtual ICollection<AffiliatedCustomer> AffiliatedCustomers { get; set; } = new List<AffiliatedCustomer>();
}
