using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class OrderSku
{
    public int Id { get; set; }

    public int OrderItemId { get; set; }

    public string? Sku { get; set; }

    public int OrderId { get; set; }

    public DateTime? DateRegistered { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public DateTime? EffectivityDate { get; set; }

    public string? SerialNumber { get; set; }

    public int? IsSynced { get; set; }

    public DateTime? PurchasedDate { get; set; }

    public string? CardStatus { get; set; }

    public string? MemberName { get; set; }

    public int? IsExpiryNotification1 { get; set; }

    public int? IsExpiryNotification2 { get; set; }

    public string? Alias { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual OrderItem OrderItem { get; set; } = null!;
}
