using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.ModelYear).GreaterThanOrEqualTo(1886);
            RuleFor(c => c.ModelYear).LessThanOrEqualTo(2023);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(0);
            RuleFor(c => c.Description).MinimumLength(10);
            RuleFor(c => c.Description).MaximumLength(500);
        }
    }
}
