using System;
using System.Collections.Generic;

namespace KlaraKarl;

public partial class Allergy
{
    public long Id { get; set; }

    public byte[]? Allergy1 { get; set; }

    public long? RwspId { get; set; }

    public virtual Rwsp? Rwsp { get; set; }
}
