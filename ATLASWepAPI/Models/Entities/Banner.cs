using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class Banner
{
    public int Id { get; set; }

    public int PictureId { get; set; }

    public string? Text { get; set; }

    public string? Link { get; set; }

    public string? AltText { get; set; }

    public bool IsDeleted { get; set; }
}
