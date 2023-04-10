using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BostonCodeCampSessionTracker.Models;

public partial class Speaker
{
    public int SpeakerId { get; set; }
    [StringLength(1)]
    public string SpeakerFname { get; set; } = null!;
    [StringLength(50)]
    public string SpeakerLname { get; set; } = null!;
    [EmailAddress]
    public string? SpeakerEmail { get; set; }
    [Phone]
    public string? SpeakerPhone { get; set; }
    [Phone]
    public string SpeakerDayOfContact { get; set; } = null!;
}
