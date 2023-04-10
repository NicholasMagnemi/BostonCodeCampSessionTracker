using BostonCodeCampSessionTracker.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonCodeCampSessionTracker.Validations
{
    public class SpeakerValidator : AbstractValidator<Speaker>
    {
        public SpeakerValidator() 
        {
            RuleFor(speaker => speaker.SpeakerFname).Length(1, 50);
            RuleFor(speaker => speaker.SpeakerLname).Length(1, 50);
            //RuleFor()
        }
    }
}
