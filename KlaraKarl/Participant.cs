using System;
using System.Collections.Generic;

namespace KlaraKarl;

public partial class Participant
{
    public long Id { get; set; }

    public long? Type { get; set; }

    public string? Surname { get; set; }

    public string? Firstname { get; set; }

    public virtual ParticipantType? TypeNavigation { get; set; }
}
