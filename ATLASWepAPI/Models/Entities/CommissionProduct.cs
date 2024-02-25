using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class CommissionProduct
{
    public int Id { get; set; }

    public int CommissionId { get; set; }

    public int ProductId { get; set; }

    public virtual Commission Commission { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
