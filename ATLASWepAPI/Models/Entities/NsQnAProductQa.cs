using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class NsQnAProductQa
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int CustomerId { get; set; }

    public string? QuestionText { get; set; }

    public string? AnswerText { get; set; }

    public bool IsApproved { get; set; }

    public bool IsAnonymous { get; set; }

    public int StoreId { get; set; }

    public int UpdatedByCustomerId { get; set; }

    public DateTime CreatedOnUtc { get; set; }

    public DateTime UpdatedOnUtc { get; set; }

    public bool Deleted { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
