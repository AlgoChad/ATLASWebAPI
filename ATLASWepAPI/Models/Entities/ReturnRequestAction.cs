using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class ReturnRequestAction
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int DisplayOrder { get; set; }
}
