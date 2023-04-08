using System;
using System.Collections.Generic;

namespace BostonCodeCampSessionTracker.Models;

public partial class TimeSlot
{
    public int TimeId { get; set; }

    public TimeSpan TimeBegin { get; set; }

    public TimeSpan TimeEnd { get; set; }

    public decimal? TimeDuration { get; set; }
}
