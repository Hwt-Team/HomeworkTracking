using Entities.Concrete;
using FluentValidation;

namespace Business.CrossCuttingConcerns.Validation
{
    public class ExerciseValidator : AbstractValidator<Exercise>
    {
        public ExerciseValidator()
        {
            RuleFor(e => e.Id).NotEmpty();
            RuleFor(e => e.Title).NotEmpty();
            RuleFor(e => e.Title).MinimumLength(3);
        }
    }
}
