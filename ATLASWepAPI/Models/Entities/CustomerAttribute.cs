﻿using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class CustomerAttribute
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsRequired { get; set; }

    public int AttributeControlTypeId { get; set; }

    public int DisplayOrder { get; set; }

    public virtual ICollection<CustomerAttributeValue> CustomerAttributeValues { get; set; } = new List<CustomerAttributeValue>();
}
