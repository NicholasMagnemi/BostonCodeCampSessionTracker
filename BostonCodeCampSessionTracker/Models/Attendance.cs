using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonCodeCampSessionTracker.Models
{
    public partial class Attendance
    {
        public string sessionName { get; set; }
        public string roomName { get; set; }
        public int countBefore { get; set; }
        public int countDuring { get; set; }
        public int countAfter { get; set; }
    }
}
