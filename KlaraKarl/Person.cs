﻿using System;
using System.Collections.Generic;

namespace KlaraKarl;

public partial class Person
{
    public string? Name { get; set; }

    public string? Email { get; set; }

    public long Id { get; set; }

    public virtual ICollection<Rwsp> Rwsps { get; } = new List<Rwsp>();
}
