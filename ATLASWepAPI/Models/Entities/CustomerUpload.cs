using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class CustomerUpload
{
    public int CustomerId { get; set; }

    public string Name { get; set; } = null!;

    public string Path { get; set; } = null!;

    public string FileType { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;
}
