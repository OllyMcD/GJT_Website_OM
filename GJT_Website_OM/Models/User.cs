using System;
using System.Collections.Generic;

namespace GJT_Website_OM.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Phone { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Postcode { get; set; } = null!;

    public DateOnly Dob { get; set; }

    public string Score { get; set; } = null!;

    public int ProgressMaths { get; set; }

    public int ProgressPhysics { get; set; }

    public int ProgressComputing { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
