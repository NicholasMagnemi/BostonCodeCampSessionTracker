using System;
using System.Collections.Generic;

namespace BostonCodeCampSessionTracker.Models;

public partial class Room
{
    public int RoomId { get; set; }

    public int RoomMaxOcc { get; set; }

    public string RoomName { get; set; } = null!;

    public virtual ICollection<Session> Sessions { get; } = new List<Session>();
}
