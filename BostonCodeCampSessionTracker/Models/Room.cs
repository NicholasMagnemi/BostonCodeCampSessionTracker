using System;
using System.Collections.Generic;

namespace SemesterProjectTest.Models
{
    public partial class Room
    {
        public Guid RoomId { get; set; }

        public int RoomMaxOcc { get; set; }

        public string RoomName { get; set; } = null!;
    }
}