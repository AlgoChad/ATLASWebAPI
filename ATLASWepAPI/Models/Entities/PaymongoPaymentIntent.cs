using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class PaymongoPaymentIntent
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public string? IntentId { get; set; }

    public virtual Order Order { get; set; } = null!;
}
