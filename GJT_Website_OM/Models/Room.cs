using System;
using System.Collections.Generic;

namespace GJT_Website_OM.Models;

public partial class Room
{
    public int RoomNumber { get; set; }

    public int? Capacity { get; set; }

    public string? RoomType { get; set; }

    public virtual ICollection<Roombooking> Roombookings { get; set; } = new List<Roombooking>();
}
