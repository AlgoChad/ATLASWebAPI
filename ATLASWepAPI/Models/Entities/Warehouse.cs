using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class Warehouse
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? AdminComment { get; set; }

    public int AddressId { get; set; }

    public virtual ICollection<ProductWarehouseInventory> ProductWarehouseInventories { get; set; } = new List<ProductWarehouseInventory>();
}
