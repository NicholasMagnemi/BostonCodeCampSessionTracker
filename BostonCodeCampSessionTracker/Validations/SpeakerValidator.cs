using BostonCodeCampSessionTracker.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BostonCodeCampSessionTracker.Validations
{
    public class SpeakerValidator : AbstractValidator<Speaker>
    {
        public SpeakerValidator() 
        {
            RuleFor(speaker => speaker.SpeakerFname).Length(1, 25).WithMessage("First name was invalid");
            RuleFor(speaker => speaker.SpeakerLname).Length(1, 25).WithMessage("Last name was invalid");
            RuleFor(speaker => speaker.SpeakerEmail).EmailAddress().WithMessage("Email address was invalid");
            RuleFor(speaker => speaker.SpeakerPhone).MinimumLength(10).MaximumLength(20).WithMessage("Phone Number was Invalid");
            RuleFor(speaker => speaker.SpeakerDayOfContact).MinimumLength(10).MaximumLength(20).WithMessage("Day Of Contact Phone Number was invalid");
            RuleFor(speaker => speaker.SpeakerBio).Length(0, 500).WithMessage("The biography is invalid"); ;
            RuleFor(speaker => speaker.SpeakerPastTalks).Length(0, 500).WithMessage("Past Talks are invalid");



        }
    }
}