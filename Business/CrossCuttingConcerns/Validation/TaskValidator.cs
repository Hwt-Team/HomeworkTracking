using Entities.Concrete;
using FluentValidation;

namespace Business.CrossCuttingConcerns.Validation
{
    public class TaskValidator : AbstractValidator<Task>
    {
        public TaskValidator()
        {
            RuleFor(t => t.Title).NotEmpty();
            RuleFor(t => t.StateId).NotEmpty();
        }
    }
}
