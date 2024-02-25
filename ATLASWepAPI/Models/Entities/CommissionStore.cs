using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class CommissionStore
{
    public int Id { get; set; }

    public int CommissionId { get; set; }

    public int StoreId { get; set; }

    public virtual Commission Commission { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;
}
