using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class OrderReferenceNumber
{
    public int OrderId { get; set; }

    public string? ReferenceNumber { get; set; }

    public virtual Order Order { get; set; } = null!;
}
