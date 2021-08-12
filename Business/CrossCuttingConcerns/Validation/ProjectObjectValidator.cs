using Core.Entities.Concrete;
using FluentValidation;
using System;

namespace Business.CrossCuttingConcerns.Validation
{
    public class ProjectObjectValidator : AbstractValidator<ProjectObject>
    {
        public ProjectObjectValidator()
        {
            RuleFor(p => p.NameSpace).NotEmpty();
            RuleFor(p => p.ClassName).NotEmpty();
            RuleFor(p => p.ObjectName).NotEmpty();
        }
    }
}
