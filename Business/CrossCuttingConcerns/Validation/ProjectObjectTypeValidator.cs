using Core.Entities.Concrete;
using FluentValidation;

namespace Business.CrossCuttingConcerns.Validation
{
    public class ProjectObjectTypeValidator:AbstractValidator<ProjectObjectType>
    {
        public ProjectObjectTypeValidator()
        {
            RuleFor(p => p.Name.Trim()).NotEmpty();
            RuleFor(p => p.Name).NotNull();
        }
    }
}
