using System;
using System.Collections.Generic;

namespace KlaraKarl.Entities;

public partial class Participant
{
    public long Id { get; set; }

    public string? ParticipantFirstname { get; set; }

    public long? ParticipantRoleId { get; set; }

    public string? ParticipantSurname { get; set; }

    public virtual ParticipantType? ParticipantRole { get; set; }
}
