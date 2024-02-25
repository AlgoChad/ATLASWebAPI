using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class WidgetZone
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string SystemName { get; set; } = null!;

    public string? TransitionEffects { get; set; }

    public int AutoPlayInterval { get; set; }

    public int SlideDuration { get; set; }

    public int MinDragOffsetToSlide { get; set; }

    public int SlideSpacing { get; set; }

    public int MinSlideWidgetZoneWidth { get; set; }

    public int MaxSlideWidgetZoneWidth { get; set; }

    public bool AutoPlay { get; set; }

    public int ArrowNavigationDisplayingTypeId { get; set; }

    public int BulletNavigationDisplayingTypeId { get; set; }

    public bool Published { get; set; }

    public bool SubjectToAcl { get; set; }

    public bool LimitedToStores { get; set; }

    public virtual ICollection<WidgetZoneSlide> WidgetZoneSlides { get; set; } = new List<WidgetZoneSlide>();
}
