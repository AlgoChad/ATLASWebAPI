using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class NopAdvanceUrlRedirect
{
    public int Id { get; set; }

    public string? OldUrl { get; set; }

    public string? NewUrl { get; set; }

    public int StoreId { get; set; }

    public bool Published { get; set; }
}
