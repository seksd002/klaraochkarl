using System;
using System.Collections.Generic;

namespace KlaraKarl.Entities;

public partial class User
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Password { get; set; }

    public string? Role { get; set; }

}

