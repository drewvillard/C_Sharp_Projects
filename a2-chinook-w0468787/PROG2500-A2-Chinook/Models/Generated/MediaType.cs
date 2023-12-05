﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PROG2500_A3_Chinook_Linq.Models;

[Table("MediaType")]
public partial class MediaType
{
    [Key]
    public int MediaTypeId { get; set; }

    [StringLength(120)]
    public string? Name { get; set; }

    [InverseProperty("MediaType")]
    public virtual ICollection<Track> Tracks { get; } = new List<Track>();
}
