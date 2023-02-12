using System;
using System.Collections.Generic;

namespace KlaraKarl;

public partial class ParticipantType
{
    public string? Role { get; set; }

    public long Id { get; set; }

    public virtual ICollection<Participant> Participants { get; } = new List<Participant>();
}
