using System;
using System.Collections.Generic;

namespace GJT_Website_OM.Models;

public partial class Tracking
{
    public int Id { get; set; }

    public string? IpAddress { get; set; }

    public string? Action { get; set; }

    public DateTime? Timestamp { get; set; }
}
