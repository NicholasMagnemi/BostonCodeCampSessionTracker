using System;
using System.Collections.Generic;


namespace SemesterProjectTest.Models
{
    public partial class Session
    {
        public Guid SessionId { get; set; }

        public string SessionTitle { get; set; } = null!;

        public int RoomId { get; set; }

        public int SpeakerId { get; set; }

        public int TimeId { get; set; }
    }
}