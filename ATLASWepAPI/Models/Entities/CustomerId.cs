using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class CustomerId
{
    public int Id { get; set; }

    public int CustomerId1 { get; set; }

    public string? IdType { get; set; }

    public string? IdNumber { get; set; }

    public string? IdStoragePath { get; set; }

    public virtual Customer CustomerId1Navigation { get; set; } = null!;
}
