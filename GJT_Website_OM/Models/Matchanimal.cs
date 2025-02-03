using System;
using System.Collections.Generic;

namespace GJT_Website_OM.Models;

public partial class Matchanimal
{
    public int AnimalFemaleId { get; set; }

    public int AnimalMaleId { get; set; }

    public DateOnly DateOfMatch { get; set; }

    public bool Successful { get; set; }

    public virtual Animal AnimalFemale { get; set; } = null!;

    public virtual Animal AnimalMale { get; set; } = null!;
}
