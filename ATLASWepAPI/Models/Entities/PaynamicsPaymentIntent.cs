using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class PaynamicsPaymentIntent
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public string? PaymentLink { get; set; }

    public virtual Order Order { get; set; } = null!;
}
