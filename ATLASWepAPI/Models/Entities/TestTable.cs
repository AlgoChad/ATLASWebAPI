using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class TestTable
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public string? TestName { get; set; }

    public string? TestDescription { get; set; }

    public virtual Product Product { get; set; } = null!;
}
