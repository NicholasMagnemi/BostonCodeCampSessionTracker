using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BostonCodeCampSessionTracker.Models;
using FluentValidation;

namespace BostonCodeCampSessionTracker.Validation
{
    public class RoomValidator : AbstractValidator<Room>
    {
        public RoomValidator() 
        { 
            RuleFor(room => room.RoomMaxOcc).NotEmpty().GreaterThan(0);
            RuleFor(room => room.RoomName).NotEmpty().MinimumLength(1).MaximumLength(25);
        }

    }
}
