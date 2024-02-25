using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class WidgetZoneSlide
{
    public int Id { get; set; }

    public string? OverrideDescription { get; set; }

    public int SlideId { get; set; }

    public int WidgetZoneId { get; set; }

    public int DisplayOrder { get; set; }

    public virtual Slide Slide { get; set; } = null!;

    public virtual WidgetZone WidgetZone { get; set; } = null!;
}
