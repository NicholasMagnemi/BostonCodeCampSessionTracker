using System;
using System.Collections.Generic;

namespace BostonCodeCampSessionTracker.Models;

public partial class SessionSpeaker
{
    public int SessionSpeakerId { get; set; }

    public int SpeakerId { get; set; }

    public int SessionId { get; set; }

    public virtual Session Session { get; set; } = null!;

    public virtual Speaker Speaker { get; set; } = null!;
}
