﻿using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class RecurringPaymentHistory
{
    public int Id { get; set; }

    public int RecurringPaymentId { get; set; }

    public int OrderId { get; set; }

    public DateTime CreatedOnUtc { get; set; }

    public virtual RecurringPayment RecurringPayment { get; set; } = null!;
}
