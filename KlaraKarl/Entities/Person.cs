using System;
using System.Collections.Generic;

namespace KlaraKarl.Entities;

public partial class Person
{
    public string? Name { get; set; }

    public string? Email { get; set; }

    public long Id { get; set; }

    public long? RwspId { get; set; }

    public virtual Rwsp? Rwsp { get; set; }
}
