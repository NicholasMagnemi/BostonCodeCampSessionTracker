using System;
using System.Collections.Generic;

namespace SemesterProjectTest.Models
{
    public partial class Speaker
    {
        public Guid SpeakerId { get; set; }

        public string SpeakerFname { get; set; } = null!;

        public string SpeakerLname { get; set; } = null!;

        public string? SpeakerEmail { get; set; }

        public string? SpeakerPhone { get; set; }

        public string SpeakerDayOfContact { get; set; } = null!;
    }
}