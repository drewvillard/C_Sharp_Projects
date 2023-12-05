﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PROG2500_A3_Chinook_Linq.Models;

[Table("Artist")]
public partial class Artist
{
    [Key]
    public int ArtistId { get; set; }

    [StringLength(120)]
    public string? Name { get; set; }

    [InverseProperty("Artist")]
    public virtual ICollection<Album> Albums { get; } = new List<Album>();
}
