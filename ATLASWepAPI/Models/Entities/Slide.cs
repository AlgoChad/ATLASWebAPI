using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class Slide
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? PictureId { get; set; }

    public string? Description { get; set; }

    public string? HyperlinkAddress { get; set; }

    public DateTime? StartDateUtc { get; set; }

    public DateTime? EndDateUtc { get; set; }

    public bool Published { get; set; }

    public bool LimitedToStores { get; set; }

    public bool SubjectToAcl { get; set; }

    public virtual ICollection<WidgetZoneSlide> WidgetZoneSlides { get; set; } = new List<WidgetZoneSlide>();
}
