using BostonCodeCampSessionTracker.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonCodeCampSessionTracker.Validations
{
    internal class AttendanceValidator:AbstractValidator<Attendance>
    {
        //RuleFor(Attendance => Attendance.)

    // RuleFor(room => room.RoomMaxOcc).NotEmpty().GreaterThan(0);
    }
}
