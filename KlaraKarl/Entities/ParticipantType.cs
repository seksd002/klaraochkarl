using System;
using System.Collections.Generic;

namespace KlaraKarl.Entities;

public partial class ParticipantType
{
    public long Id { get; set; }

    public string? ParticipantRoleName { get; set; }

    public virtual ICollection<Participant> Participants { get; } = new List<Participant>();
}
