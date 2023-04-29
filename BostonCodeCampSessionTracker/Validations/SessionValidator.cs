/*using BostonCodeCampSessionTracker.Models;
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
            RuleFor(session => session.SessionTitle).NotEmpty().MaximumLength(15);
            RuleFor(session => session.RoomId).NotEmpty();
            RuleFor(session => session.SpeakerId).NotEmpty();
            RuleFor(session => session.TimeId).NotEmpty();

        }
    }
}*/
