using BostonCodeCampSessionTracker.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonCodeCampSessionTracker.Validations
{
     class CountValidator : AbstractValidator<Count>
    {
        public CountValidator()
        {
            RuleFor(count => count.BeginningCount).NotEmpty().GreaterThan(0).WithMessage("The beginning count is invalid");
            RuleFor(count => count.MiddleCount).NotEmpty().GreaterThan(0).WithMessage("The middle count is invalid");
            RuleFor(count => count.EndingCount).NotEmpty().GreaterThan(0).WithMessage("The ending count is invalid");
        }
        
    }
}
