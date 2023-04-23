using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonCodeCampSessionTracker.Models
{
    public partial class Attendance
    {
        public int SessionId { get; set; }
        public string roomName { get; set; }
        public string beforeCount { get; set; }
        public string duringCount { get; set; }
        public string afterCount { get; set; }
    }
}
