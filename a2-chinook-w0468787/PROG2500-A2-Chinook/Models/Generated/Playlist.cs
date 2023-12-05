﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PROG2500_A3_Chinook_Linq.Models;

[Table("Playlist")]
public partial class Playlist
{
    [Key]
    public int PlaylistId { get; set; }

    [StringLength(120)]
    public string? Name { get; set; }

    [ForeignKey("PlaylistId")]
    [InverseProperty("Playlists")]
    public virtual ICollection<Track> Tracks { get; } = new List<Track>();
}
