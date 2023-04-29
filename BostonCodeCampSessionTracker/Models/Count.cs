using System;
using System.Collections.Generic;

namespace BostonCodeCampSessionTracker.Models;

public partial class Count
{
    public int CountId { get; set; }

    public int? BeginningCount { get; set; }

    public int? MiddleCount { get; set; }

    public int? EndingCount { get; set; }
}
