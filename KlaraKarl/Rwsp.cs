using System;
using System.Collections.Generic;

namespace KlaraKarl;

public partial class Rwsp
{
    public long? PersonId { get; set; }

    public long Id { get; set; }

    public string? Otherinfo { get; set; }

    public virtual ICollection<Allergy> Allergies { get; } = new List<Allergy>();

    public virtual Person? Person { get; set; }
}
