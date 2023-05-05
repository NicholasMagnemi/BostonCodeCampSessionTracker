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

    public int? AttendeeCountBegin { get; set; }

    public int? AttendeeCountMid { get; set; }

    public int? AttendeeCountEnd { get; set; }

    public virtual Room Room { get; set; } = null!;

    public virtual Speaker Speaker { get; set; } = null!;

    public virtual TimeSlot Time { get; set; } = null!;
}
