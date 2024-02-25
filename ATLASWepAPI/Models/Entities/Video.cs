using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class Video
{
    public int Id { get; set; }

    public string VideoUrl { get; set; } = null!;

    public virtual ICollection<ProductVideo> ProductVideos { get; set; } = new List<ProductVideo>();
}
