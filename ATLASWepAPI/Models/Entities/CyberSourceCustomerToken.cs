using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class CyberSourceCustomerToken
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public string SubscriptionId { get; set; } = null!;

    public string LastFourDigitOfCard { get; set; } = null!;

    public string? FirstSixDigitOfCard { get; set; }

    public string CardExpirationYear { get; set; } = null!;

    public string CardExpirationMonth { get; set; } = null!;

    public string? ThreeDigitCardType { get; set; }

    public string? InstrumentIdentifier { get; set; }

    public string? InstrumentIdentifierStatus { get; set; }

    public string? CyberSourceCustomerId { get; set; }

    public string? TransactionId { get; set; }

    public bool IsInstrumentIdentifierNew { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
