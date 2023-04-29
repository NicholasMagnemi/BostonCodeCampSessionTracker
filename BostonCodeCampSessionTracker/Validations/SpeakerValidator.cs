/*using BostonCodeCampSessionTracker.Models;
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
            RuleFor(speaker => speaker.SpeakerFname).Length(1, 50);
            RuleFor(speaker => speaker.SpeakerLname).Length(1, 50);
            RuleFor(speaker => speaker.SpeakerEmail).EmailAddress();
            RuleFor(speaker => speaker.SpeakerPhone).MinimumLength(10).MaximumLength(20).Matches(new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}"));
            RuleFor(speaker => speaker.SpeakerDayOfContact).MinimumLength(10).MaximumLength(20).Matches(new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}"));
            RuleFor(speaker => speaker.SpeakerBio).Length(0, 500);
            RuleFor(speaker => speaker.SpeakerPastTalks).Length(0, 500);


        }
    }
}*/