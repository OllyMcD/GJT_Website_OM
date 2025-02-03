﻿using System;
using System.Collections.Generic;

namespace GJT_Website_OM.Models;

public partial class Ticket
{
    public int TicketId { get; set; }

    public int AttractionId { get; set; }

    public int Ticketbookingid { get; set; }

    public virtual Attraction Attraction { get; set; } = null!;

    public virtual Ticketbooking Ticketbooking { get; set; } = null!;
}
