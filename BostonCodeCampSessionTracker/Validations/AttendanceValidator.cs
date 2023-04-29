/*using BostonCodeCampSessionTracker.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonCodeCampSessionTracker.Validations
{
     class AttendanceValidator : AbstractValidator<Attendance>
    {
        public AttendanceValidator()
        {
            RuleFor(Attendance => Attendance.SessionId).NotEmpty().GreaterThan(0);
            RuleFor(Attendance => Attendance.roomName).NotEmpty().MinimumLength(1).MaximumLength(25);
            RuleFor(Attendance => Attendance.beforeCount).NotEmpty();
            RuleFor(Attendance => Attendance.duringCount).NotEmpty();
            RuleFor(Attendance => Attendance.afterCount).NotEmpty();
        }
        
    }
}*/
