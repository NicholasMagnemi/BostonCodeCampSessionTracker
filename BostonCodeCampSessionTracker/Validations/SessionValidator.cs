using BostonCodeCampSessionTracker.Models;
using FluentValidation;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonCodeCampSessionTracker.Validations
{
    internal class SessionValidator : AbstractValidator<Session>
    {
        public SessionValidator() 
        { 
            RuleFor(session => session.SessionTitle).NotEmpty().MaximumLength(15).WithMessage("The Session's title is invalid");
            RuleFor(session => session.RoomId).NotEmpty().WithMessage("The Room ID is invalid");
            RuleFor(session => session.SpeakerId).NotEmpty();
            RuleFor(session => session.TimeId).NotEmpty();
            RuleFor(session => session.AttendeeCountBegin).GreaterThanOrEqualTo(0);
            RuleFor(session => session.AttendeeCountMid).GreaterThanOrEqualTo(0);
            RuleFor(session => session.AttendeeCountEnd).GreaterThanOrEqualTo(0);
        }
    }
}
