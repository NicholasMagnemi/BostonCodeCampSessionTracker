using System;
using System.Collections.Generic;

namespace BostonCodeCampSessionTracker.Models;

public partial class Speaker
{
    public int SpeakerId { get; set; }

    public string? SpeakerFname { get; set; }

    public string? SpeakerLname { get; set; }

    public string? SpeakerEmail { get; set; }

    public string? SpeakerPhone { get; set; }

    public string? SpeakerDayOfContact { get; set; }

    public string? SpeakerBio { get; set; }

    public string? SpeakerPastTalks { get; set; }

    public virtual ICollection<SessionSpeaker> SessionSpeakers { get; set; } = new List<SessionSpeaker>();

    public virtual ICollection<Session> Sessions { get; set; } = new List<Session>();
}
