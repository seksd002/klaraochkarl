using System;
using System.Collections.Generic;

namespace KlaraKarl;

public partial class Rwsp
{
    public long? PersonId { get; set; }

    public int Id { get; set; }

    public virtual Person? Person { get; set; }
}
