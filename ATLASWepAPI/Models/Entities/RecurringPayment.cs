﻿using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class RecurringPayment
{
    public int Id { get; set; }

    public int InitialOrderId { get; set; }

    public int CycleLength { get; set; }

    public int CyclePeriodId { get; set; }

    public int TotalCycles { get; set; }

    public DateTime StartDateUtc { get; set; }

    public bool IsActive { get; set; }

    public bool LastPaymentFailed { get; set; }

    public bool Deleted { get; set; }

    public DateTime CreatedOnUtc { get; set; }

    public virtual Order InitialOrder { get; set; } = null!;

    public virtual ICollection<RecurringPaymentHistory> RecurringPaymentHistories { get; set; } = new List<RecurringPaymentHistory>();
}
