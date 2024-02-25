using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class AffiliatedOrder
{
    public int Id { get; set; }

    public string CommissionStatus { get; set; } = null!;

    public DateTime? CommissionPaidOn { get; set; }

    public decimal TotalCommission { get; set; }

    public int? OrderItemId { get; set; }

    public int? AffiliateId { get; set; }

    public int CommissionId { get; set; }
}
