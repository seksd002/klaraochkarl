using System;
using System.Collections.Generic;

namespace KlaraKarl;

public partial class Person
{
    public string? Name { get; set; }

    public string? Email { get; set; }

    public int Id { get; set; }

    public String? OtherInfo {get;set;}

    public virtual ICollection<Rwsp> Rwsps { get; } = new List<Rwsp>();
}
