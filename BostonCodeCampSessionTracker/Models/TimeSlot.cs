using System;
using System.Collections.Generic;

namespace SemesterProjectTest.Models
{
    public partial class TimeSlot
    {
        public Guid TimeId { get; set; }

        public TimeSpan TimeBegin { get; set; }

        public TimeSpan TimeEnd { get; set; }

        public decimal? TimeDuration { get; set; }
    }
}