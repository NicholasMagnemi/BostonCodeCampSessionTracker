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
    internal class TimeSlotValidator : AbstractValidator<TimeSlot>
    {
        public TimeSlotValidator() 
        {
            RuleFor(timeSlot => timeSlot.TimeBegin).NotEmpty().WithMessage("Start Time is required");
            RuleFor(timeSlot => timeSlot.TimeEnd).NotEmpty().WithMessage("End Time is required");
            RuleFor(timeSlot => timeSlot.TimeBegin).LessThan(TimeSlot => TimeSlot.TimeEnd).WithMessage("Start Time must be before End Time");
        }
    }
}
