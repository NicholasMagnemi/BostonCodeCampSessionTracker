using System;
using System.Collections.Generic;

namespace BostonCodeCampSessionTracker.Models;

public partial class Session
{
    public int SessionId { get; set; }

    public string SessionTitle { get; set; } = null!;

    public int RoomId { get; set; }

    public int SpeakerId { get; set; }

    public int TimeId { get; set; }

    public virtual Room Room { get; set; } = null!;

    public virtual ICollection<SessionSpeaker> SessionSpeakers { get; } = new List<SessionSpeaker>();

    public virtual Speaker Speaker { get; set; } = null!;

    public virtual TimeSlot Time { get; set; } = null!;
}
