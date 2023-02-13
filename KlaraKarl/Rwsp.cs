﻿using System;
using System.Collections.Generic;

namespace KlaraKarl;

public partial class Rwsp
{
    public long Id { get; set; }

    public string? Otherinfo { get; set; }

    public virtual ICollection<Allergy> Allergies { get; } = new List<Allergy>();

    public virtual ICollection<Person> People { get; } = new List<Person>();
}
