﻿using BostonCodeCampSessionTracker.Models;
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
            RuleFor(count => count.BeginningCount).NotEmpty().GreaterThan(0);
            RuleFor(count => count.MiddleCount).NotEmpty().GreaterThan(0); ;
            RuleFor(count => count.EndingCount).NotEmpty();
        }
        
    }
}