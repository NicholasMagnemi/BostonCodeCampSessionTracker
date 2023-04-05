using System;
using System.Collections.Generic;

namespace SemesterProjectTest.Models
{
    public partial class SessionSpeaker
    {
        public Guid SessionSpeakerId { get; set; }

        public int SpeakerId { get; set; }

        public int SessionId { get; set; }
    }
}