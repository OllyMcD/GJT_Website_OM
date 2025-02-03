using System;
using System.Collections.Generic;

namespace GJT_Website_OM.Models;

public partial class Ticketbooking
{
    public int CustomerId { get; set; }

    public int TicketbookingId { get; set; }

    public DateOnly DateBooked { get; set; }

    public DateOnly Date { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
