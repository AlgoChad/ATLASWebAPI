using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class MailChimpSynchronizationRecord
{
    public int Id { get; set; }

    public int EntityTypeId { get; set; }

    public int EntityId { get; set; }

    public int OperationTypeId { get; set; }

    public string? Email { get; set; }

    public int ProductId { get; set; }
}
