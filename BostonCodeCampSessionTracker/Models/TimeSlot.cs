using System;
using System.Collections.Generic;

namespace BostonCodeCampSessionTracker.Models;

public partial class TimeSlot
{
    public int TimeId { get; set; }

    public TimeSpan TimeBegin { get; set; }

    public TimeSpan TimeEnd { get; set; }

    public TimeSpan? TimeDuration { get; set; }

    public virtual ICollection<Session> Sessions { get; } = new List<Session>();
}
