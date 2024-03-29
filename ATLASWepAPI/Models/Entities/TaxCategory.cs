﻿using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class TaxCategory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int DisplayOrder { get; set; }
}
