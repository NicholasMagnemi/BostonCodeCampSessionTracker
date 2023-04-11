using System;
using System.Collections.Generic;

namespace BostonCodeCampSessionTracker.Models;

public partial class Speaker
{
    public int SpeakerId { get; set; }

    public string SpeakerFname { get; set; } = null!;

    public string SpeakerLname { get; set; } = null!;

    public string? SpeakerEmail { get; set; }

    public string? SpeakerPhone { get; set; }

    public string SpeakerDayOfContact { get; set; } = null!;

    public string SpeakerBio { get; set; } = null!;

    public string SpeakerPastTalks { get; set; } = null!;

    public virtual ICollection<SessionSpeaker> SessionSpeakers { get; } = new List<SessionSpeaker>();

    public virtual ICollection<Session> Sessions { get; } = new List<Session>();
}
