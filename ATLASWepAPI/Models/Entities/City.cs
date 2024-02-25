using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class City
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int StateId { get; set; }

    public bool Published { get; set; }

    public int DisplayOrder { get; set; }

    public virtual StateProvince State { get; set; } = null!;
}
