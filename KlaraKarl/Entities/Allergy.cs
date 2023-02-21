using System;
using System.Collections.Generic;

namespace KlaraKarl.Entities;

public partial class Allergy
{
    public long Id { get; set; }

    public string? Allergy1 { get; set; }

    public bool checkbox { get; set; } = true;

    public long? RwspId { get; set; }

    public virtual Rwsp? Rwsp { get; set; }
}
