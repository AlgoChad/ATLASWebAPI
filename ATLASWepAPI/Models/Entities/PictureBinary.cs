﻿using System;
using System.Collections.Generic;

namespace ATLASWepAPI.Models.Entities;

public partial class PictureBinary
{
    public int Id { get; set; }

    public int PictureId { get; set; }

    public byte[]? BinaryData { get; set; }

    public virtual Picture Picture { get; set; } = null!;
}
